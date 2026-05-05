using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>The mesh grading specifies how fine details of the geometry are resolved and also influences the quality of the resulting elements.If you select the automatic grading, you can specify how fine your mesh should be (ranging from 1 - very coarse to 5 - very fine) and all additional parameters will be set automatically.For full control over the underlying parameters number of segements per edge, number of segements per radius and growth rate you can choose the manual mesh grading option. The figure shows meshes for grading 1 - very coarse (left) and 5 - very fine (right).</summary>
[JsonConverter(typeof(OneOf_ManualMeshSizingGradingConverter))]
public interface OneOf_ManualMeshSizingGrading { }

internal class OneOf_ManualMeshSizingGradingConverter : JsonConverter<OneOf_ManualMeshSizingGrading>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticMeshGrading),
        ["MANUAL"] = typeof(ManualMeshGrading),
    };

    public override OneOf_ManualMeshSizingGrading? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ManualMeshSizingGrading?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ManualMeshSizingGrading value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
