using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Sun direction in the solar radiation model. Custom: Define the sun direction vector directly.Time and place: Set the sun direction by defining a location, a date and a time. This assumes the Z-vector to point upwards into the sky.</summary>
[JsonConverter(typeof(OneOf_SolarCalculatorSunDirectionConverter))]
public interface OneOf_SolarCalculatorSunDirection { }

internal class OneOf_SolarCalculatorSunDirectionConverter : JsonConverter<OneOf_SolarCalculatorSunDirection>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TIME_AND_PLACE"] = typeof(TimeAndPlaceSunDirection),
        ["CUSTOM_SOLAR_DIRECTION"] = typeof(CustomSunDirection),
    };

    public override OneOf_SolarCalculatorSunDirection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolarCalculatorSunDirection?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolarCalculatorSunDirection value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
