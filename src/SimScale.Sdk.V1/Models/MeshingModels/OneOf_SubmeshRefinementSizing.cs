using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Choose how your mesh element sizes should be defined:If you select the Automatic sizing, you can specify how fine your mesh should be (ranging from Very coarse to Very fine) and all additional parameters will be set automatically according to the chosen fineness and the geometry features.For full control over the mesh sizing, select the Manual option. Here you can define the Minimum edge length and Maximum edge length. The figure shows meshes with fineness Very coarse (left) and Very fine (right).</summary>
[JsonConverter(typeof(OneOf_SubmeshRefinementSizingConverter))]
public interface OneOf_SubmeshRefinementSizing { }

internal class OneOf_SubmeshRefinementSizingConverter : JsonConverter<OneOf_SubmeshRefinementSizing>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticMeshSizing),
        ["MANUAL"] = typeof(ManualMeshSizing),
    };

    public override OneOf_SubmeshRefinementSizing? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SubmeshRefinementSizing?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SubmeshRefinementSizing value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
