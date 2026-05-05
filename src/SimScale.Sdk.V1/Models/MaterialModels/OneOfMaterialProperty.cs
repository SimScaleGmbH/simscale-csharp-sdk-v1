using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MaterialModels;

[JsonConverter(typeof(OneOfMaterialPropertyConverter))]
public interface OneOfMaterialProperty { }

internal class OneOfMaterialPropertyConverter : JsonConverter<OneOfMaterialProperty>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["fixed"] = typeof(FixedMaterialProperty),
        ["parametric"] = typeof(ParametricMaterialProperty),
    };

    public override OneOfMaterialProperty? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("valueType", out var discProp))
            throw new JsonException("Missing discriminator property \"valueType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"valueType\"");
        return ((OneOfMaterialProperty?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOfMaterialProperty value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
