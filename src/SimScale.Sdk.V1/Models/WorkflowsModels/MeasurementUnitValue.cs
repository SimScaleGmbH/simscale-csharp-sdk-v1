using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for a measurement unit value. Resolves to a text JSON node.</summary>
[JsonConverter(typeof(MeasurementUnitValueConverter))]
public interface MeasurementUnitValue { }

internal class MeasurementUnitValueConverter : JsonConverter<MeasurementUnitValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["unit:constant"] = typeof(MeasurementUnitConstant),
        ["unit:expression:select"] = typeof(MeasurementUnitExpressionSelect),
        ["unit:function:pow"] = typeof(MeasurementUnitFunctionPow),
        ["unit:operation:div"] = typeof(MeasurementUnitOperationDiv),
        ["unit:operation:times"] = typeof(MeasurementUnitOperationTimes),
        ["unit:reference"] = typeof(MeasurementUnitReference),
    };

    public override MeasurementUnitValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((MeasurementUnitValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, MeasurementUnitValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
