using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dissipation rate (epsilon) represents the rate of dissipation of turbulent kinetic energy (k). Learn more.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCEddyViscosityCompressibleConverter))]
public interface OneOf_CustomFluidBCEddyViscosityCompressible { }

internal class OneOf_CustomFluidBCEddyViscosityCompressibleConverter : JsonConverter<OneOf_CustomFluidBCEddyViscosityCompressible>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CALCULATED"] = typeof(CalculatedEVCBC),
        ["SYMMETRY"] = typeof(SymmetryEVCBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientEVCBC),
        ["FIXED_VALUE"] = typeof(FixedValueEVCBC),
        ["INLET_OUTLET"] = typeof(InletOutletEVCBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientEVCBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionEVCBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionEVCBC),
    };

    public override OneOf_CustomFluidBCEddyViscosityCompressible? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCEddyViscosityCompressible?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCEddyViscosityCompressible value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
