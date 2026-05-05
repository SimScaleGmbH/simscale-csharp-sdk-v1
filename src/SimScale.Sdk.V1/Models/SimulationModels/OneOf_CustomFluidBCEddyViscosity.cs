using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dynamic eddy viscosity (muSgs) is a sub-grid scale viscosity used to model the unresolved turbulent eddies in Large Eddy Simulations. Choose a boundary type.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCEddyViscosityConverter))]
public interface OneOf_CustomFluidBCEddyViscosity { }

internal class OneOf_CustomFluidBCEddyViscosityConverter : JsonConverter<OneOf_CustomFluidBCEddyViscosity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CALCULATED"] = typeof(CalculatedEVBC),
        ["SYMMETRY"] = typeof(SymmetryEVBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientEVBC),
        ["FIXED_VALUE"] = typeof(FixedValueEVBC),
        ["INLET_OUTLET"] = typeof(InletOutletEVBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientEVBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionEVBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionEVBC),
    };

    public override OneOf_CustomFluidBCEddyViscosity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCEddyViscosity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCEddyViscosity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
