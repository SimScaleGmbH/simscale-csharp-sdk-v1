using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defined by the number of statistically independent links (N) in a polymer chain, this determines the material's extensibility. It dictates the "locking stretch" point where chains become fully extended and the stress-strain curve turns sharply upward.</summary>
[JsonConverter(typeof(OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunctionConverter))]
public interface OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunction { }

internal class OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunctionConverter : JsonConverter<OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunction>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CONSTANT"] = typeof(ConstantFunction),
        ["EXPRESSION"] = typeof(ExpressionFunction),
        ["POLYNOMIAL"] = typeof(PolynomialFunction),
        ["TABLE_DEFINED"] = typeof(TableDefinedFunction),
    };

    public override OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunction?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ArrudaBoycePlasticElastoplasticNetworkChainLengthFunction value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
