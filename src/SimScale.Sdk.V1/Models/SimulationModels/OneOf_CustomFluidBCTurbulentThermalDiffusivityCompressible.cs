using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dynamic turbulent thermal diffusivity (alpha_Sgs) represents the rate of turbulent heat transfer.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressibleConverter))]
public interface OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible { }

internal class OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressibleConverter : JsonConverter<OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CALCULATED"] = typeof(CalculatedTDCBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientTDCBC),
        ["FIXED_VALUE"] = typeof(FixedValueTDCBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientTDCBC),
        ["SYMMETRY"] = typeof(SymmetryTDCBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionTDCBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionTDCBC),
    };

    public override OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCTurbulentThermalDiffusivityCompressible value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
