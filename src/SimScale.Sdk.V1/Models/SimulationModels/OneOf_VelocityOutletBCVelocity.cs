using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose the type of velocity boundary condition. Learn more.</summary>
[JsonConverter(typeof(OneOf_VelocityOutletBCVelocityConverter))]
public interface OneOf_VelocityOutletBCVelocity { }

internal class OneOf_VelocityOutletBCVelocityConverter : JsonConverter<OneOf_VelocityOutletBCVelocity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_VALUE"] = typeof(FixedValueVBC),
        ["FIXED_MEAN"] = typeof(MeanValueVBC),
        ["FREESTREAM"] = typeof(FreestreamVBC),
        ["OUTLET_MEAN_PHASE"] = typeof(OutletMeanPhaseVBC),
        ["FLOW_RATE_OUTLET_VELOCITY"] = typeof(FlowRateOutletVBC),
        ["FLOW_RATE_MEAN_OUTLET_VELOCITY"] = typeof(FlowRateMeanOutletVBC),
        ["FLOW_RATE_STABLE_OUTLET_VELOCITY"] = typeof(FlowRateStableOutletVBC),
        ["MEAN_VALUE_OUTLET_VELOCITY"] = typeof(MeanValueOutletVBC),
    };

    public override OneOf_VelocityOutletBCVelocity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_VelocityOutletBCVelocity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_VelocityOutletBCVelocity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
