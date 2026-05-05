using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SolidCompressibleMaterialRadiativeBehaviorConverter))]
public interface OneOf_SolidCompressibleMaterialRadiativeBehavior { }

internal class OneOf_SolidCompressibleMaterialRadiativeBehaviorConverter : JsonConverter<OneOf_SolidCompressibleMaterialRadiativeBehavior>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TRANSPARENT_MATERIAL"] = typeof(TransparentMaterial),
        ["SEMI_TRANSPARENT_MATERIAL"] = typeof(SemiTransparentMaterial),
        ["OPAQUE_MATERIAL"] = typeof(OpaqueMaterial),
    };

    public override OneOf_SolidCompressibleMaterialRadiativeBehavior? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidCompressibleMaterialRadiativeBehavior?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidCompressibleMaterialRadiativeBehavior value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
