using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for a list of values. Resolves to a JSON array.</summary>
[JsonConverter(typeof(ValueListIntegerValueConverter))]
public interface ValueListIntegerValue { }

internal class ValueListIntegerValueConverter : JsonConverter<ValueListIntegerValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["list:constant"] = typeof(ConstantValueList),
        ["list:expression:select"] = typeof(ValueListExpressionSelect),
        ["list:function:drop"] = typeof(ValueListFunctionDrop),
        ["list:function:drop_last"] = typeof(ValueListFunctionDropLast),
        ["list:function:filter"] = typeof(ValueListFunctionFilter),
        ["list:function:map"] = typeof(ValueListFunctionMap),
        ["list:function:sublist"] = typeof(ValueListFunctionSubList),
        ["list:function:take"] = typeof(ValueListFunctionTake),
        ["list:function:take_last"] = typeof(ValueListFunctionTakeLast),
        ["list:generator:integer_sequence"] = typeof(IntegerSequenceGenerator),
        ["list:generator:real_sequence"] = typeof(RealSequenceGenerator),
        ["list:operation:plus"] = typeof(ValueListOperationPlus),
        ["list:operation:times"] = typeof(ValueListOperationTimes),
        ["list:reference"] = typeof(ReferenceValueList),
    };

    public override ValueListIntegerValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((ValueListIntegerValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, ValueListIntegerValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
