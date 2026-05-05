using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select the porous material behavior: Homogeneous: Uniform resistance to fluid flow in all directions.Directional: Resistance to fluid flow in one or two directions.</summary>
[JsonConverter(typeof(OneOf_PressureLossFunctionMediumPorousMaterialTypeConverter))]
public interface OneOf_PressureLossFunctionMediumPorousMaterialType { }

internal class OneOf_PressureLossFunctionMediumPorousMaterialTypeConverter : JsonConverter<OneOf_PressureLossFunctionMediumPorousMaterialType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["HOMOGENEOUS"] = typeof(HomogeneousMaterialStructure),
        ["DIRECTIONAL"] = typeof(DirectionalMaterialStructure),
    };

    public override OneOf_PressureLossFunctionMediumPorousMaterialType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PressureLossFunctionMediumPorousMaterialType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PressureLossFunctionMediumPorousMaterialType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
