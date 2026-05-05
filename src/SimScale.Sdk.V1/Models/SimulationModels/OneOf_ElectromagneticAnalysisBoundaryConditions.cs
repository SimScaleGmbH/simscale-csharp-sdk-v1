using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ElectromagneticAnalysisBoundaryConditionsConverter))]
public interface OneOf_ElectromagneticAnalysisBoundaryConditions { }

internal class OneOf_ElectromagneticAnalysisBoundaryConditionsConverter : JsonConverter<OneOf_ElectromagneticAnalysisBoundaryConditions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MAGNETIC_FIELD_NORMAL"] = typeof(MagneticFieldNormal),
        ["MAGNETIC_FLUX_TANGENTIAL"] = typeof(MagneticFluxTangential),
        ["FIXED_POTENTIAL"] = typeof(FixedPotential),
        ["FLOATING_POTENTIAL"] = typeof(FloatingPotential),
        ["CHARGE_DENSITY"] = typeof(ChargeDensity),
        ["TOTAL_CHARGE"] = typeof(TotalCharge),
        ["FIXED_TEMPERATURE"] = typeof(FixedTemperature),
        ["SURFACE_HEAT_FLUX"] = typeof(SurfaceHeatFlux),
        ["VOLUME_HEAT_FLUX"] = typeof(VolumeHeatFlux),
        ["CONVECTIVE_HEAT_FLUX"] = typeof(ConvectiveHeatFlux),
        ["RADIATION_HEAT_FLUX"] = typeof(RadiationHeatFlux),
    };

    public override OneOf_ElectromagneticAnalysisBoundaryConditions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticAnalysisBoundaryConditions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticAnalysisBoundaryConditions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
