using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The stiffness can either be assumed equal in all directions by selecting isotropic or it can depend on the force direction by selecting orthotropic. For an orthotropic stiffness the stiffness value along each global coordinate direction can be given independently.</summary>
[JsonConverter(typeof(OneOf_ElasticSupportBCSpringStiffnessConverter))]
public interface OneOf_ElasticSupportBCSpringStiffness { }

internal class OneOf_ElasticSupportBCSpringStiffnessConverter : JsonConverter<OneOf_ElasticSupportBCSpringStiffness>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicSpringStiffness),
        ["ORTHOTROPIC"] = typeof(OrthotropicSpringStiffness),
    };

    public override OneOf_ElasticSupportBCSpringStiffness? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElasticSupportBCSpringStiffness?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElasticSupportBCSpringStiffness value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
