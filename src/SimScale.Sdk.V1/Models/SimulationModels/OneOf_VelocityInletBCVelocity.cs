using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose the type of velocity boundary condition. Learn more.</summary>
[JsonConverter(typeof(OneOf_VelocityInletBCVelocityConverter))]
public interface OneOf_VelocityInletBCVelocity { }

internal class OneOf_VelocityInletBCVelocityConverter : JsonConverter<OneOf_VelocityInletBCVelocity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_VALUE"] = typeof(FixedValueVBC),
        ["FIXED_MEAN"] = typeof(MeanValueVBC),
        ["FIXED_VALUE_NO_EXPRESSION"] = typeof(FixedMagnitudeVBC),
        ["FLOW_RATE_INLET_VELOCITY"] = typeof(FlowRateInletVBC),
        ["FLOW_RATE_MEAN_INLET_VELOCITY"] = typeof(FlowRateMeanInletVBC),
        ["FREESTREAM"] = typeof(FreestreamVBC),
    };

    public override OneOf_VelocityInletBCVelocity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_VelocityInletBCVelocity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_VelocityInletBCVelocity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
