using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedConceptsMomentumSourcesConverter))]
public interface OneOf_AdvancedConceptsMomentumSources { }

internal class OneOf_AdvancedConceptsMomentumSourcesConverter : JsonConverter<OneOf_AdvancedConceptsMomentumSources>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AVERAGE_VELOCITY"] = typeof(AverageVelocityMomentumSource),
        ["FAN_PRESSURE_DROP"] = typeof(FanPressureDropMomentumSource),
        ["FRICTION_VELOCITY_SOURCE"] = typeof(FrictionVelocityMomentumSource),
    };

    public override OneOf_AdvancedConceptsMomentumSources? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedConceptsMomentumSources?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedConceptsMomentumSources value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
