using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

[JsonConverter(typeof(GeometryPrimitiveConverter))]
public interface GeometryPrimitive { }

internal class GeometryPrimitiveConverter : JsonConverter<GeometryPrimitive>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CARTESIAN_BOX"] = typeof(CartesianBox),
        ["ROTATABLE_CARTESIAN_BOX"] = typeof(RotatableCartesianBox),
        ["LOCAL_CARTESIAN_BOX"] = typeof(LocalCartesianBox),
        ["SPHERE"] = typeof(Sphere),
        ["LOCAL_SPHERE"] = typeof(LocalSphere),
        ["CYLINDER"] = typeof(Cylinder),
        ["POINT"] = typeof(Point),
        ["BOX"] = typeof(Box),
        ["HALF_SPACE"] = typeof(HalfSpace),
        ["LOCAL_HALF_SPACE"] = typeof(LocalHalfSpace),
    };

    public override GeometryPrimitive? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((GeometryPrimitive?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, GeometryPrimitive value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
