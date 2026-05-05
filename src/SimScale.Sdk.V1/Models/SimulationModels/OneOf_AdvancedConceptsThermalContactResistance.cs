using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedConceptsThermalContactResistanceConverter))]
public interface OneOf_AdvancedConceptsThermalContactResistance { }

internal class OneOf_AdvancedConceptsThermalContactResistanceConverter : JsonConverter<OneOf_AdvancedConceptsThermalContactResistance>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["THIN_RESISTANCE_LAYER"] = typeof(ThinResistanceLayer),
        ["CONTACT_RESISTANCE_LAYER"] = typeof(ContactResistanceLayer),
        ["CONTACT_CONDUCTANCE_LAYER"] = typeof(ContactConductanceLayer),
    };

    public override OneOf_AdvancedConceptsThermalContactResistance? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedConceptsThermalContactResistance?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedConceptsThermalContactResistance value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
