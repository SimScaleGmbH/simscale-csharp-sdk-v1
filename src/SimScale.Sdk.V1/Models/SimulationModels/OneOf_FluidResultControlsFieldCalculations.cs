using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FluidResultControlsFieldCalculationsConverter))]
public interface OneOf_FluidResultControlsFieldCalculations { }

internal class OneOf_FluidResultControlsFieldCalculationsConverter : JsonConverter<OneOf_FluidResultControlsFieldCalculations>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PRESSURE"] = typeof(FieldCalculationsPressureResultControl),
        ["TURBULENCE"] = typeof(FieldCalculationsTurbulenceResultControl),
        ["VELOCITY"] = typeof(FieldCalculationsVelocityResultControl),
        ["FRICTION_VELOCITY_U_TAU"] = typeof(FieldCalculationsFrictionVelocityResultControl),
        ["SURFACE_NORMALS"] = typeof(FieldCalculationsSurfaceNormalsResultControl),
        ["WALL_FLUXES"] = typeof(FieldCalculationsWallFluxesResultControl),
        ["AGE_OF_FLUID"] = typeof(FieldCalculationsMeanAgeOfFluidResultControl),
        ["THERMAL_COMFORT"] = typeof(FieldCalculationsThermalComfortResultControl),
        ["ADJOINT_SENSITIVITIES"] = typeof(FieldCalculationsAdjointSensitivitiesResultControl),
        ["WALL_HEAT_FLUX"] = typeof(FieldCalculationsWallHeatFluxResultControl),
        ["MEAN_RADIANT_TEMPERATURE"] = typeof(FieldCalculationsMeanRadiantTemperatureResultControl),
        ["OPERATIVE_TEMPERATURE"] = typeof(FieldCalculationsOperativeTemperatureResultControl),
        ["RESOLVED_TURBULENT_KINETIC_ENERGY"] = typeof(FieldCalculationsResolvedTKEResultControl),
        ["TOTAL_TURBULENT_KINETIC_ENERGY"] = typeof(FieldCalculationsTotalTKEResultControl),
        ["MODELED_TURBULENCE_INTENSITY"] = typeof(FieldCalculationsModeledTIResultControl),
        ["RESOLVED_TURBULENCE_INTENSITY"] = typeof(FieldCalculationsResolvedTIResultControl),
        ["TOTAL_TURBULENCE_INTENSITY"] = typeof(FieldCalculationsTotalTIResultControl),
    };

    public override OneOf_FluidResultControlsFieldCalculations? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FluidResultControlsFieldCalculations?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FluidResultControlsFieldCalculations value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
