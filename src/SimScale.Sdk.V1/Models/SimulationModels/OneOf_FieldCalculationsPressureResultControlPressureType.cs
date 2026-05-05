using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FieldCalculationsPressureResultControlPressureTypeConverter))]
public interface OneOf_FieldCalculationsPressureResultControlPressureType { }

internal class OneOf_FieldCalculationsPressureResultControlPressureTypeConverter : JsonConverter<OneOf_FieldCalculationsPressureResultControlPressureType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL_PRESSURE"] = typeof(TotalPressurePressureType),
        ["STATIC_PRESSURE"] = typeof(StaticPressurePressureType),
    };

    public override OneOf_FieldCalculationsPressureResultControlPressureType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FieldCalculationsPressureResultControlPressureType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FieldCalculationsPressureResultControlPressureType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
