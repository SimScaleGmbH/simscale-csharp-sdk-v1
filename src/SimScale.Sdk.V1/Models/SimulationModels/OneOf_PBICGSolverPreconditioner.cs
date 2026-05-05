using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose a preconditioner for your solver. A preconditioner improves the convergence speed of your system. Therefore, it is generally recommended. DILU is a very common diagonal incomplete lower-upper decomposition preconditioner.</summary>
[JsonConverter(typeof(OneOf_PBICGSolverPreconditionerConverter))]
public interface OneOf_PBICGSolverPreconditioner { }

internal class OneOf_PBICGSolverPreconditionerConverter : JsonConverter<OneOf_PBICGSolverPreconditioner>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DILU"] = typeof(DILUPreconditioner),
        ["ILUCP"] = typeof(ILUCpPreconditioner),
    };

    public override OneOf_PBICGSolverPreconditioner? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PBICGSolverPreconditioner?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PBICGSolverPreconditioner value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
