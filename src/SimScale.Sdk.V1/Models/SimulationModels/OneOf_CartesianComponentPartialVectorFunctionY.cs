using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_CartesianComponentPartialVectorFunctionYConverter))]
public interface OneOf_CartesianComponentPartialVectorFunctionY { }

internal class OneOf_CartesianComponentPartialVectorFunctionYConverter : JsonConverter<OneOf_CartesianComponentPartialVectorFunctionY>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PRESCRIBED"] = typeof(PrescribedOptionalFunction),
        ["UNCONSTRAINED"] = typeof(UnconstrainedOptionalFunction),
    };

    public override OneOf_CartesianComponentPartialVectorFunctionY? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CartesianComponentPartialVectorFunctionY?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CartesianComponentPartialVectorFunctionY value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
