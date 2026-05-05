using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for modified gauge pressure (p_rgh). Learn more.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCGaugePressureRghConverter))]
public interface OneOf_CustomFluidBCGaugePressureRgh { }

internal class OneOf_CustomFluidBCGaugePressureRghConverter : JsonConverter<OneOf_CustomFluidBCGaugePressureRgh>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SYMMETRY"] = typeof(SymmetryPBC),
        ["FAN_PRESSURE"] = typeof(FanPBC),
        ["FIXED_FLUX_PRESSURE"] = typeof(FixedFluxPBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientPBC),
        ["FIXED_VALUE"] = typeof(FixedValuePBC),
        ["FREESTREAM"] = typeof(FreestreamPBC),
        ["FIXED_MEAN"] = typeof(MeanValuePBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientPBC),
        ["TOTAL_PRESSURE"] = typeof(TotalPBC),
        ["HYDROSTATIC_ISOTHERMAL_FAN_PRESSURE"] = typeof(HydrostaticFanPBC),
    };

    public override OneOf_CustomFluidBCGaugePressureRgh? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCGaugePressureRgh?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCGaugePressureRgh value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
