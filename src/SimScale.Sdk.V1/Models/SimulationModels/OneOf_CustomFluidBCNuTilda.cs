using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>nuTilda is a Spalart-Allmaras variable which is a function of eddy viscosity. Choose a boundary type.</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCNuTildaConverter))]
public interface OneOf_CustomFluidBCNuTilda { }

internal class OneOf_CustomFluidBCNuTildaConverter : JsonConverter<OneOf_CustomFluidBCNuTilda>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SYMMETRY"] = typeof(SymmetryNBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientNBC),
        ["FIXED_VALUE"] = typeof(FixedValueNBC),
        ["INLET_OUTLET"] = typeof(InletOutletNBC),
        ["ZERO_GRADIENT"] = typeof(ZeroGradientNBC),
        ["WALL_FUNCTION"] = typeof(WallFunctionNBC),
        ["FULL_RESOLUTION"] = typeof(FullResolutionNBC),
    };

    public override OneOf_CustomFluidBCNuTilda? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCNuTilda?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCNuTilda value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
