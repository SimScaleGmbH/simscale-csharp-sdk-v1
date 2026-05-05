using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dissipation rate (epsilon) represents the rate of dissipation of turbulent kinetic energy (k). Learn more.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCEpsilonDissipationRateConverter))]
public interface OneOf_CustomFluidBCEpsilonDissipationRate { }

internal class OneOf_CustomFluidBCEpsilonDissipationRateConverter : JsonConverter<OneOf_CustomFluidBCEpsilonDissipationRate>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SYMMETRY"] = typeof(SymmetryEBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientEBC),
        ["FIXED_VALUE"] = typeof(FixedValueEBC),
        ["INLET_OUTLET"] = typeof(InletOutletEBC),
        ["TURBULENCE_MIXING_LENGTH_DISSIPATION_RATE_INLET"] = typeof(MixingLengthInletEBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientEBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionEBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionEBC),
    };

    public override OneOf_CustomFluidBCEpsilonDissipationRate? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCEpsilonDissipationRate?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCEpsilonDissipationRate value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
