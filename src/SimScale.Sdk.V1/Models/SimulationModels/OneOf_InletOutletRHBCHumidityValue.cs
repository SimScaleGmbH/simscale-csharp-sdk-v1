using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_InletOutletRHBCHumidityValueConverter))]
public interface OneOf_InletOutletRHBCHumidityValue { }

internal class OneOf_InletOutletRHBCHumidityValueConverter : JsonConverter<OneOf_InletOutletRHBCHumidityValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["RELATIVE_HUMIDITY_VALUE"] = typeof(RelativeHumidityValue),
        ["SPECIFIC_HUMIDITY_VALUE"] = typeof(SpecificHumidityValue),
        ["ABSOLUTE_HUMIDITY_VALUE"] = typeof(AbsoluteHumidityValue),
    };

    public override OneOf_InletOutletRHBCHumidityValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_InletOutletRHBCHumidityValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_InletOutletRHBCHumidityValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
