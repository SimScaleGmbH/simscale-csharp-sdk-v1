using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Number of terms in the Ogden model.</summary>
[JsonConverter(typeof(OneOf_OgdenHyperElasticModelOrderConverter))]
public interface OneOf_OgdenHyperElasticModelOrder { }

internal class OneOf_OgdenHyperElasticModelOrderConverter : JsonConverter<OneOf_OgdenHyperElasticModelOrder>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIRST_ORDER_OGDEN"] = typeof(FirstOrderOgden),
        ["SECOND_ORDER_OGDEN"] = typeof(SecondOrderOgden),
        ["THIRD_ORDER_OGDEN"] = typeof(ThirdOrderOgden),
    };

    public override OneOf_OgdenHyperElasticModelOrder? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_OgdenHyperElasticModelOrder?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_OgdenHyperElasticModelOrder value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
