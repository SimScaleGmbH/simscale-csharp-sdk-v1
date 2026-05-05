using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>The Curvature setting allows the user to specify the mesh refinement on curved features. By default, this is Automatic. Alternatively, the user can specify the curvature in terms of number of mesh nodes in a circle using Relative. Curvature refinement is not supported for Geometry primitive region refinement.</summary>
[JsonConverter(typeof(OneOf_SimmetrixLocalSizingRefinementCurvatureConverter))]
public interface OneOf_SimmetrixLocalSizingRefinementCurvature { }

internal class OneOf_SimmetrixLocalSizingRefinementCurvatureConverter : JsonConverter<OneOf_SimmetrixLocalSizingRefinementCurvature>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_CURVATURE"] = typeof(AutomaticCurvature),
        ["RELATIVE_CURVATURE"] = typeof(RelativeCurvature),
    };

    public override OneOf_SimmetrixLocalSizingRefinementCurvature? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixLocalSizingRefinementCurvature?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixLocalSizingRefinementCurvature value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
