using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the directional dependency for this property:Isotropic material: all the material properties are the same in all directionsOrthotropic material: different material properties in different orthogonal directions (e.g. glass-reinforced plastic, or wood)</summary>
[JsonConverter(typeof(OneOf_LinearElasticMaterialBehaviorDirectionalDependencyConverter))]
public interface OneOf_LinearElasticMaterialBehaviorDirectionalDependency { }

internal class OneOf_LinearElasticMaterialBehaviorDirectionalDependencyConverter : JsonConverter<OneOf_LinearElasticMaterialBehaviorDirectionalDependency>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicDirectionalDependency),
        ["ORTHOTROPIC"] = typeof(OrthotropicDirectionalDependency),
    };

    public override OneOf_LinearElasticMaterialBehaviorDirectionalDependency? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_LinearElasticMaterialBehaviorDirectionalDependency?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_LinearElasticMaterialBehaviorDirectionalDependency value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
