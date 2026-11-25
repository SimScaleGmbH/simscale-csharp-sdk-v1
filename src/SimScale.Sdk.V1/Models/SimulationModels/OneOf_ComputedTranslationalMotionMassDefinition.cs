using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>How the mass of the moving body is obtained.Specified &amp;mdash; enter the mass directly. The usual choice, since a data sheet normally quotes it.From density &amp;mdash; the mass is computed as the density of the material assigned to the body times the volume of its mesh. The electromagnetic material needs a density for this.</summary>
[JsonConverter(typeof(OneOf_ComputedTranslationalMotionMassDefinitionConverter))]
public interface OneOf_ComputedTranslationalMotionMassDefinition { }

internal class OneOf_ComputedTranslationalMotionMassDefinitionConverter : JsonConverter<OneOf_ComputedTranslationalMotionMassDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SPECIFIED_MASS"] = typeof(SpecifiedMass),
        ["MASS_FROM_DENSITY"] = typeof(MassFromDensity),
    };

    public override OneOf_ComputedTranslationalMotionMassDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ComputedTranslationalMotionMassDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ComputedTranslationalMotionMassDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
