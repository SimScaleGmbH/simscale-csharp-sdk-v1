using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_PorousTreeTreeTypeConverter))]
public interface OneOf_PorousTreeTreeType { }

internal class OneOf_PorousTreeTreeTypeConverter : JsonConverter<OneOf_PorousTreeTreeType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CUSTOM_TREE"] = typeof(CustomTree),
        ["PLANE_TREE"] = typeof(PlaneTree),
        ["OAK"] = typeof(Oak),
        ["SYCAMORE"] = typeof(Sycamore),
        ["SILVER_BIRCH"] = typeof(SilverBirch),
        ["CHESTNUT"] = typeof(Chestnut),
    };

    public override OneOf_PorousTreeTreeType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PorousTreeTreeType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PorousTreeTreeType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
