using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedConceptsPowerSourcesConverter))]
public interface OneOf_AdvancedConceptsPowerSources { }

internal class OneOf_AdvancedConceptsPowerSourcesConverter : JsonConverter<OneOf_AdvancedConceptsPowerSources>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ABSOLUTE_V23"] = typeof(AbsolutePowerSource),
        ["SPECIFIC_V23"] = typeof(SpecificPowerSource),
        ["HEAT_EXCHANGER_SOURCE"] = typeof(HeatExchangerSource),
        ["TR_ABSOLUTE_POWER_SOURCE"] = typeof(TrAbsolutePowerSource),
        ["TR_SPECIFIC_POWER_SOURCE"] = typeof(TrSpecificPowerSource),
    };

    public override OneOf_AdvancedConceptsPowerSources? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedConceptsPowerSources?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedConceptsPowerSources value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
