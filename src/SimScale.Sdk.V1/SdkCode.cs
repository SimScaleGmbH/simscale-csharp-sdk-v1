using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1;

/// <summary>
/// Generates C# SDK v1 code from a simulation/meshing spec.
///
/// Library usage:
///     var code = SdkCode.GenerateSdkCode(projectId: "PID", simulationId: Guid.Parse("SID"));
///
/// Uses the same SIMSCALE_API_KEY / SIMSCALE_API_URL environment variables as the SDK.
/// </summary>
public static class SdkCode
{
    private const int IndentWidth = 4;

    private static readonly Dictionary<string, string> NamespaceAliases = new()
    {
        ["SimulationModels"] = "Sim",
        ["MeshingModels"] = "Mesh",
        ["MaterialModels"] = "Mat",
        ["CadModels"] = "Cad",
        ["GeometryPrimitiveModels"] = "Geo",
        ["ParametricModels"] = "Param",
        ["PostprocessingModels"] = "Pp",
        ["ReportingModels"] = "Rpt",
    };

    // -----------------------------------------------------------------
    // Namespace helpers
    // -----------------------------------------------------------------

    private static string? GetSubNamespace(Type type)
    {
        var ns = type.Namespace;
        if (ns == null || !ns.StartsWith("SimScale.Sdk.V1.Models."))
            return null;
        return ns["SimScale.Sdk.V1.Models.".Length..];
    }

    private static string QualifiedName(Type type)
    {
        var subNs = GetSubNamespace(type);
        if (subNs != null)
        {
            var alias = NamespaceAliases.GetValueOrDefault(subNs, subNs);
            return $"{alias}.{type.Name}";
        }
        return type.Name;
    }

    private static bool IsModelType(Type type)
    {
        return type.Namespace != null
               && type.Namespace.StartsWith("SimScale.Sdk.V1.Models")
               && type.IsClass
               && !type.IsAbstract
               && !type.IsGenericType;
    }

    // -----------------------------------------------------------------
    // Code emitter - recursively convert model objects to C# source code
    // -----------------------------------------------------------------

    private static string Emit(object? value, int indentLevel, HashSet<Type> imports)
    {
        if (value == null) return "null";

        var type = value.GetType();

        if (IsModelType(type))
            return EmitModel(value, indentLevel, imports);

        if (value is IList list)
            return EmitList(list, indentLevel, imports);

        if (value is IDictionary dict)
            return EmitDict(dict, indentLevel, imports);

        if (value is bool b)
            return b ? "true" : "false";

        if (value is string s)
            return $"\"{EscapeString(s)}\"";

        if (value is Guid g)
            return $"Guid.Parse(\"{g}\")";

        if (value is DateTimeOffset dto)
            return $"DateTimeOffset.Parse(\"{dto:O}\")";

        if (value is double d)
            return d.ToString(CultureInfo.InvariantCulture);

        if (value is float f)
            return f.ToString(CultureInfo.InvariantCulture) + "f";

        if (value is long l)
            return l.ToString();

        return value.ToString()!;
    }

    private static string EmitModel(object obj, int indentLevel, HashSet<Type> imports)
    {
        var type = obj.GetType();
        imports.Add(type);
        var name = QualifiedName(type);

        // Create default instance to compare property values against initializers
        object? defaultInstance = null;
        try { defaultInstance = Activator.CreateInstance(type); }
        catch { /* required keyword is compile-time only, this normally succeeds */ }

        var props = new List<(string Name, string Code)>();

        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var jsonAttr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
            if (jsonAttr == null) continue;

            // Skip discriminator "type" property (always has a default value)
            if (jsonAttr.Name == "type" && prop.PropertyType == typeof(string))
            {
                var val = prop.GetValue(obj);
                if (val != null) continue;
            }

            var value = prop.GetValue(obj);
            if (IsDefaultOrEmpty(value, prop, defaultInstance)) continue;

            var valueCode = Emit(value, indentLevel + 1, imports);
            props.Add((prop.Name, valueCode));
        }

        if (props.Count == 0)
            return $"new {name}()";

        var sb = new StringBuilder();
        sb.Append($"new {name}");
        sb.AppendLine();
        sb.Append($"{Prefix(indentLevel)}{{");

        foreach (var (propName, code) in props)
        {
            sb.AppendLine();
            sb.Append($"{Prefix(indentLevel + 1)}{propName} = {code},");
        }

        sb.AppendLine();
        sb.Append($"{Prefix(indentLevel)}}}");
        return sb.ToString();
    }

    private static string EmitList(IList list, int indentLevel, HashSet<Type> imports)
    {
        if (list.Count == 0) return "[]";

        var sb = new StringBuilder();
        sb.AppendLine("[");

        for (var i = 0; i < list.Count; i++)
        {
            sb.Append($"{Prefix(indentLevel + 1)}{Emit(list[i], indentLevel + 1, imports)},");
            sb.AppendLine();
        }

        sb.Append($"{Prefix(indentLevel)}]");
        return sb.ToString();
    }

    private static string EmitDict(IDictionary dict, int indentLevel, HashSet<Type> imports)
    {
        if (dict.Count == 0) return "new() {}";

        var sb = new StringBuilder();
        sb.AppendLine("new()");
        sb.Append($"{Prefix(indentLevel)}{{");

        foreach (DictionaryEntry entry in dict)
        {
            var keyCode = Emit(entry.Key, indentLevel + 1, imports);
            var valCode = Emit(entry.Value, indentLevel + 1, imports);
            sb.AppendLine();
            sb.Append($"{Prefix(indentLevel + 1)}[{keyCode}] = {valCode},");
        }

        sb.AppendLine();
        sb.Append($"{Prefix(indentLevel)}}}");
        return sb.ToString();
    }

    // -----------------------------------------------------------------
    // Helpers
    // -----------------------------------------------------------------

    private static bool IsDefaultOrEmpty(object? value, PropertyInfo prop, object? defaultInstance)
    {
        if (value == null) return true;
        if (value is IList { Count: 0 }) return true;
        if (value is IDictionary { Count: 0 }) return true;
        if (value is Guid g && g == Guid.Empty
            && prop.GetCustomAttribute<JsonRequiredAttribute>() == null) return true;

        if (defaultInstance == null) return false;

        var defaultValue = prop.GetValue(defaultInstance);
        if (!Equals(value, defaultValue)) return false;

        // Value matches the default instance. Skip it — unless this is a required
        // value type whose default is just the CLR zero (0, false, Guid.Empty).
        // In that case the zero IS the real value and must be emitted.
        if (prop.GetCustomAttribute<JsonRequiredAttribute>() != null
            && prop.PropertyType.IsValueType
            && Equals(defaultValue, Activator.CreateInstance(prop.PropertyType)))
            return false;

        return true;
    }

    private static string Prefix(int level) => new(' ', level * IndentWidth);

    private static string EscapeString(string s) =>
        s.Replace("\\", "\\\\")
         .Replace("\"", "\\\"")
         .Replace("\n", "\\n")
         .Replace("\r", "\\r")
         .Replace("\t", "\\t");

    // -----------------------------------------------------------------
    // Using directive generation
    // -----------------------------------------------------------------

    private static string GenerateUsings(HashSet<Type> imports)
    {
        var hasRoot = false;
        var subNamespaces = new SortedSet<string>();

        foreach (var type in imports)
        {
            var subNs = GetSubNamespace(type);
            if (subNs != null)
                subNamespaces.Add(subNs);
            else
                hasRoot = true;
        }

        var lines = new List<string>();
        if (hasRoot)
            lines.Add("using SimScale.Sdk.V1.Models;");
        foreach (var ns in subNamespaces)
        {
            var alias = NamespaceAliases.GetValueOrDefault(ns, ns);
            lines.Add($"using {alias} = SimScale.Sdk.V1.Models.{ns};");
        }
        return string.Join(Environment.NewLine, lines);
    }

    // -----------------------------------------------------------------
    // Public API
    // -----------------------------------------------------------------

    /// <summary>
    /// Generate C# SDK v1 code by fetching a spec from the SimScale API.
    ///
    /// Provide <paramref name="projectId"/> with one of <paramref name="simulationId"/> /
    /// <paramref name="meshOperationId"/>. When <paramref name="simulationRunId"/> is also
    /// provided alongside <paramref name="simulationId"/>, the run spec is fetched instead.
    ///
    /// Uses the same SIMSCALE_API_KEY / SIMSCALE_API_URL environment variables as SimScaleSDK.
    /// </summary>
    public static string GenerateSdkCode(
        string projectId,
        Guid? simulationId = null,
        Guid? simulationRunId = null,
        Guid? meshOperationId = null)
    {
        if (simulationId.HasValue && meshOperationId.HasValue)
            throw new ArgumentException("Cannot specify both simulationId and meshOperationId");

        using var sdk = new SimScaleSDK();
        object model;

        if (simulationId.HasValue && simulationRunId.HasValue)
            model = sdk.SimulationRuns.GetSimulationRunSpec(
                projectId, simulationId.Value, simulationRunId.Value).Model;
        else if (simulationId.HasValue)
            model = sdk.Simulations.GetSimulation(projectId, simulationId.Value).Model;
        else if (meshOperationId.HasValue)
            model = sdk.MeshOperations.GetMeshOperation(projectId, meshOperationId.Value).Model;
        else
            throw new ArgumentException("Either simulationId or meshOperationId must be provided");

        var imports = new HashSet<Type>();
        var code = Emit(model, 0, imports);
        var usingLines = GenerateUsings(imports);

        var sb = new StringBuilder();
        if (usingLines.Length > 0)
        {
            sb.AppendLine(usingLines);
            sb.AppendLine();
        }
        sb.AppendLine(code);
        return sb.ToString();
    }
}
