using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ParametricModels;

[JsonConverter(typeof(OneOf_ParametersConverter))]
public interface OneOf_Parameters { }

internal class OneOf_ParametersConverter : JsonConverter<OneOf_Parameters>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CONFIGURATION"] = typeof(ParameterWithValues),
        ["GENERATOR"] = typeof(ParameterWithValueGenerator),
    };

    public override OneOf_Parameters? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("valueSource", out var discProp))
            throw new JsonException("Missing discriminator property \"valueSource\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"valueSource\"");
        return ((OneOf_Parameters?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_Parameters value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
