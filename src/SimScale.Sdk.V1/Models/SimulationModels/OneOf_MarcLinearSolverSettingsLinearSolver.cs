using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines the numerical method used to solve the linear system of equations $Ax=b$ within each iteration. Choosing the right solver depends on the model size, available memory, and the presence of instabilities.Direct (MUMPS): A robust, multi-frontal direct solver suitable for a wide range of problems, especially those with material nonlinearities or contact. It is generally more memory-intensive than iterative solvers but highly reliable for complex nonlinearities.Direct (Pardiso): A high-performance direct solver optimized for multi-core CPUs, offering efficient memory usage and fast solution times for large-scale linear and nonlinear problems. It is a good alternative to MUMPS for large models.Iterative: Best for very large, bulky models due to lower memory demand. This solver might be less robust in highly nonlinear scenarios compared to the direct solvers.</summary>
[JsonConverter(typeof(OneOf_MarcLinearSolverSettingsLinearSolverConverter))]
public interface OneOf_MarcLinearSolverSettingsLinearSolver { }

internal class OneOf_MarcLinearSolverSettingsLinearSolverConverter : JsonConverter<OneOf_MarcLinearSolverSettingsLinearSolver>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MUMPS_DIRECT"] = typeof(MumpsDirectSolver),
        ["PARDISO_DIRECT"] = typeof(PardisoDirectSolver),
        ["SPARSE_ITERATIVE"] = typeof(SparseIterative),
    };

    public override OneOf_MarcLinearSolverSettingsLinearSolver? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcLinearSolverSettingsLinearSolver?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcLinearSolverSettingsLinearSolver value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
