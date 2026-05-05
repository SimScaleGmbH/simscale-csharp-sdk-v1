using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specific dissipation rate (omega) represents the specific rate of dissipation of turbulent kinetic energy (k). Learn more.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCOmegaDissipationRateConverter))]
public interface OneOf_CustomFluidBCOmegaDissipationRate { }

internal class OneOf_CustomFluidBCOmegaDissipationRateConverter : JsonConverter<OneOf_CustomFluidBCOmegaDissipationRate>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SYMMETRY"] = typeof(SymmetryOBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientOBC),
        ["FIXED_VALUE"] = typeof(FixedValueOBC),
        ["INLET_OUTLET"] = typeof(InletOutletOBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientOBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionOBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionOBC),
    };

    public override OneOf_CustomFluidBCOmegaDissipationRate? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCOmegaDissipationRate?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCOmegaDissipationRate value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
