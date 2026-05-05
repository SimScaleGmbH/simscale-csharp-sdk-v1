using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_PressureOutletBCPhaseFractionsV2Converter))]
public interface OneOf_PressureOutletBCPhaseFractionsV2 { }

internal class OneOf_PressureOutletBCPhaseFractionsV2Converter : JsonConverter<OneOf_PressureOutletBCPhaseFractionsV2>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["OUTLET_BACK_FLOW_PF_VALUES"] = typeof(OutletBackFlowPFValues),
        ["OUTLET_FLOW_DRIVEN_PF"] = typeof(OutletFlowDrivenPF),
    };

    public override OneOf_PressureOutletBCPhaseFractionsV2? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PressureOutletBCPhaseFractionsV2?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PressureOutletBCPhaseFractionsV2 value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
