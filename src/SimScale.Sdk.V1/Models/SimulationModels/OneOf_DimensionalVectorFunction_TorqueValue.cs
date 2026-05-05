using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_DimensionalVectorFunction_TorqueValueConverter))]
public interface OneOf_DimensionalVectorFunction_TorqueValue { }

internal class OneOf_DimensionalVectorFunction_TorqueValueConverter : JsonConverter<OneOf_DimensionalVectorFunction_TorqueValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["COMPONENT"] = typeof(ComponentVectorFunction),
        ["TABLE_DEFINED"] = typeof(TableDefinedVectorFunction),
    };

    public override OneOf_DimensionalVectorFunction_TorqueValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DimensionalVectorFunction_TorqueValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DimensionalVectorFunction_TorqueValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
