using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for a dimensional vector. Resolves to an object node with field `vector` containing Cartesian vector components (`x`, `y`, `z`; as double nodes) and field `unit` (text node). Note that during resolution, all dimensionals are converted to base SI units (e.g. 50 miles/hour -&gt; 22.352 m/s),</summary>
[JsonConverter(typeof(DimensionalVectorValueConverter))]
public interface DimensionalVectorValue { }

internal class DimensionalVectorValueConverter : JsonConverter<DimensionalVectorValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["dimensional_vector:constant"] = typeof(DimensionalVectorConstant),
        ["dimensional_vector:expression:select"] = typeof(DimensionalVectorExpressionSelect),
        ["dimensional_vector:function:norm"] = typeof(DimensionalVectorFunctionNorm),
        ["dimensional_vector:operation:div"] = typeof(DimensionalVectorOperationDiv),
        ["dimensional_vector:operation:minus"] = typeof(DimensionalVectorOperationMinus),
        ["dimensional_vector:operation:plus"] = typeof(DimensionalVectorOperationPlus),
        ["dimensional_vector:operation:times"] = typeof(DimensionalVectorOperationTimes),
        ["dimensional_vector:reference"] = typeof(DimensionalVectorReference),
        ["real:conversion:to_dimensional_vector"] = typeof(DimensionalVectorFromComponents),
    };

    public override DimensionalVectorValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((DimensionalVectorValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, DimensionalVectorValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
