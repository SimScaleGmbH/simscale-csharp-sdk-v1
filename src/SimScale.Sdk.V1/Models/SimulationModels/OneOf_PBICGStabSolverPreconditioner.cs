using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose a preconditioner for your solver. A preconditioner improves the convergence speed of your system. Therefore, it is generally recommended. DILU is a very common diagonal incomplete lower-upper decomposition preconditioner.</summary>
[JsonConverter(typeof(OneOf_PBICGStabSolverPreconditionerConverter))]
public interface OneOf_PBICGStabSolverPreconditioner { }

internal class OneOf_PBICGStabSolverPreconditionerConverter : JsonConverter<OneOf_PBICGStabSolverPreconditioner>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DILU"] = typeof(DILUPreconditioner),
        ["DIC"] = typeof(DICPreconditioner),
        ["ILUCP"] = typeof(ILUCpPreconditioner),
    };

    public override OneOf_PBICGStabSolverPreconditioner? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PBICGStabSolverPreconditioner?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PBICGStabSolverPreconditioner value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
