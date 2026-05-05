using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The resulting stiffness of the elastic support can be defined either via the total stiffness expressed as force per length or the distributed stiffness expressed as force per length per area.</summary>
[JsonConverter(typeof(OneOf_OrthotropicSpringStiffnessStiffnessDefinitionConverter))]
public interface OneOf_OrthotropicSpringStiffnessStiffnessDefinition { }

internal class OneOf_OrthotropicSpringStiffnessStiffnessDefinitionConverter : JsonConverter<OneOf_OrthotropicSpringStiffnessStiffnessDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL_ORTHOTROPIC"] = typeof(TotalOrthotropicStiffnessDefinition),
        ["DISTRIBUTED_ORTHOTROPIC"] = typeof(DistributedOrthotropicStiffnessDefinition),
    };

    public override OneOf_OrthotropicSpringStiffnessStiffnessDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_OrthotropicSpringStiffnessStiffnessDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_OrthotropicSpringStiffnessStiffnessDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
