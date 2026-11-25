using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_OneTermExponent1FunctionConverter))]
public interface OneOf_OneTermExponent1Function { }

internal class OneOf_OneTermExponent1FunctionConverter : JsonConverter<OneOf_OneTermExponent1Function>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CONSTANT"] = typeof(ConstantFunction),
        ["EXPRESSION"] = typeof(ExpressionFunction),
        ["POLYNOMIAL"] = typeof(PolynomialFunction),
        ["TABLE_DEFINED"] = typeof(TableDefinedFunction),
    };

    public override OneOf_OneTermExponent1Function? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_OneTermExponent1Function?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_OneTermExponent1Function value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
