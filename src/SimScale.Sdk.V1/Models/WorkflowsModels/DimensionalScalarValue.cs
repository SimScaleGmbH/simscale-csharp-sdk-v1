using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for a dimensional scalar. Resolves to an object node with field `value` (double node) and field `unit` (text node). Note: during resolution all dimensionals are converted to base SI units (e.g. 50 miles/hour -&gt; 22.352 m/s).</summary>
[JsonConverter(typeof(DimensionalScalarValueConverter))]
public interface DimensionalScalarValue { }

internal class DimensionalScalarValueConverter : JsonConverter<DimensionalScalarValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["dimensional_scalar:constant"] = typeof(DimensionalScalarConstant),
        ["dimensional_scalar:expression:select"] = typeof(DimensionalScalarExpressionSelect),
        ["dimensional_scalar:function:pow"] = typeof(DimensionalScalarFunctionPow),
        ["dimensional_scalar:operation:div"] = typeof(DimensionalScalarOperationDiv),
        ["dimensional_scalar:operation:minus"] = typeof(DimensionalScalarOperationMinus),
        ["dimensional_scalar:operation:plus"] = typeof(DimensionalScalarOperationPlus),
        ["dimensional_scalar:operation:times"] = typeof(DimensionalScalarOperationTimes),
        ["dimensional_scalar:reference"] = typeof(DimensionalScalarReference),
        ["dimensional_vector:function:component"] = typeof(DimensionalScalarFromDimensionalVectorComponent),
        ["dimensional_vector:function:mag"] = typeof(DimensionalVectorFunctionMag),
        ["integer:conversion:to_dimensional_scalar"] = typeof(IntegerToDimensionalScalarValueConversion),
        ["real:conversion:to_dimensional_scalar"] = typeof(RealToDimensionalScalarValueConversion),
    };

    public override DimensionalScalarValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((DimensionalScalarValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, DimensionalScalarValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
