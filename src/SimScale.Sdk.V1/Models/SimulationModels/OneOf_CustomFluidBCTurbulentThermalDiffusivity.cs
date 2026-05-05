using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dynamic turbulent thermal diffusivity (alpha_t) represents the rate of turbulent heat transfer.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCTurbulentThermalDiffusivityConverter))]
public interface OneOf_CustomFluidBCTurbulentThermalDiffusivity { }

internal class OneOf_CustomFluidBCTurbulentThermalDiffusivityConverter : JsonConverter<OneOf_CustomFluidBCTurbulentThermalDiffusivity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CALCULATED"] = typeof(CalculatedTDBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientTDBC),
        ["FIXED_VALUE"] = typeof(FixedValueTDBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientTDBC),
        ["SYMMETRY"] = typeof(SymmetryTDBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionTDBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionTDBC),
    };

    public override OneOf_CustomFluidBCTurbulentThermalDiffusivity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCTurbulentThermalDiffusivity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCTurbulentThermalDiffusivity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
