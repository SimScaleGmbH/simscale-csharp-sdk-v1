using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_CustomFluidBCVelocityConverter))]
public interface OneOf_CustomFluidBCVelocity { }

internal class OneOf_CustomFluidBCVelocityConverter : JsonConverter<OneOf_CustomFluidBCVelocity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ADVECTIVE"] = typeof(AdvectiveVBC),
        ["SYMMETRY"] = typeof(SymmetryVBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientVBC),
        ["FIXED_VALUE"] = typeof(FixedValueVBC),
        ["FIXED_MEAN"] = typeof(MeanValueVBC),
        ["FLOW_RATE_INLET_VELOCITY"] = typeof(FlowRateInletVBC),
        ["FLOW_RATE_MEAN_INLET_VELOCITY"] = typeof(FlowRateMeanInletVBC),
        ["FREESTREAM"] = typeof(FreestreamVBC),
        ["INLET_OUTLET"] = typeof(InletOutletVBC),
        ["MOVING_WALL_VELOCITY"] = typeof(MovingWallVBC),
        ["NO_SLIP"] = typeof(NoSlipVBC),
        ["OUTLET_MEAN_PHASE"] = typeof(OutletMeanPhaseVBC),
        ["PRESSURE_INLET_VELOCITY"] = typeof(PressureInletVBC),
        ["PRESSURE_INLET_OUTLET_VELOCITY"] = typeof(PressureInletOutletVBC),
        ["ROTATING_WALL_VELOCITY"] = typeof(RotatingWallVBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientVBC),
        ["SLIP"] = typeof(SlipVBC),
    };

    public override OneOf_CustomFluidBCVelocity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCVelocity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCVelocity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
