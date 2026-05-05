using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for turbulent kinetic energy (k).</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCTurbulentKineticEnergyConverter))]
public interface OneOf_CustomFluidBCTurbulentKineticEnergy { }

internal class OneOf_CustomFluidBCTurbulentKineticEnergyConverter : JsonConverter<OneOf_CustomFluidBCTurbulentKineticEnergy>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SYMMETRY"] = typeof(SymmetryTKEBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientTKEBC),
        ["FIXED_VALUE"] = typeof(FixedValueTKEBC),
        ["INLET_OUTLET"] = typeof(InletOutletTKEBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientTKEBC),
        ["TURBULENT_INTENSITY_KINETIC_ENERGY_INLET"] = typeof(IntensityKineticEnergyInletTKEBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionTKEBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionTKEBC),
    };

    public override OneOf_CustomFluidBCTurbulentKineticEnergy? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCTurbulentKineticEnergy?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCTurbulentKineticEnergy value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
