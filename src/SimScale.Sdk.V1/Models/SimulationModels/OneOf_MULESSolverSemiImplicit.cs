using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_MULESSolverSemiImplicitConverter))]
public interface OneOf_MULESSolverSemiImplicit { }

internal class OneOf_MULESSolverSemiImplicitConverter : JsonConverter<OneOf_MULESSolverSemiImplicit>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FALSE_SEMI_IMPLICIT"] = typeof(FalseSemiImplicit),
        ["TRUE_SEMI_IMPLICIT"] = typeof(TrueSemiImplicit),
    };

    public override OneOf_MULESSolverSemiImplicit? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MULESSolverSemiImplicit?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MULESSolverSemiImplicit value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
