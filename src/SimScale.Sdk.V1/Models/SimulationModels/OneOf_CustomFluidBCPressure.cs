using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for pressure (p). Learn more.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCPressureConverter))]
public interface OneOf_CustomFluidBCPressure { }

internal class OneOf_CustomFluidBCPressureConverter : JsonConverter<OneOf_CustomFluidBCPressure>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ADVECTIVE"] = typeof(AdvectivePBC),
        ["SYMMETRY"] = typeof(SymmetryPBC),
        ["FAN_PRESSURE"] = typeof(FanPBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientPBC),
        ["FIXED_VALUE"] = typeof(FixedValuePBC),
        ["FREESTREAM"] = typeof(FreestreamPBC),
        ["FIXED_MEAN"] = typeof(MeanValuePBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientPBC),
        ["TOTAL_PRESSURE"] = typeof(TotalPBC),
        ["WAVE_TRANSMISSIVE"] = typeof(WaveTransmissivePBC),
        ["HYDROSTATIC_ISOTHERMAL_FAN_PRESSURE"] = typeof(HydrostaticFanPBC),
    };

    public override OneOf_CustomFluidBCPressure? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCPressure?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCPressure value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
