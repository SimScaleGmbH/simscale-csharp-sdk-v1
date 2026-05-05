using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_HingeConstraintBCAxisDefinitionConverter))]
public interface OneOf_HingeConstraintBCAxisDefinition { }

internal class OneOf_HingeConstraintBCAxisDefinitionConverter : JsonConverter<OneOf_HingeConstraintBCAxisDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CUSTOM"] = typeof(CustomAxisDefinition),
        ["AUTOMATIC"] = typeof(AutomaticAxisDefinition),
    };

    public override OneOf_HingeConstraintBCAxisDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HingeConstraintBCAxisDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HingeConstraintBCAxisDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
