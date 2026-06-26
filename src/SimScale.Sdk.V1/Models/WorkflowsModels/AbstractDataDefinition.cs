using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Abstract workflow data definition. It can be either: * input data of the workflow * output data of the workflow * other intermediate data in the workflow</summary>
[JsonConverter(typeof(AbstractDataDefinitionConverter))]
public interface AbstractDataDefinition { }

internal class AbstractDataDefinitionConverter : JsonConverter<AbstractDataDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["input"] = typeof(InputDataDefinition),
        ["intermediate"] = typeof(IntermediateDataDefinition),
        ["output"] = typeof(OutputDataDefinition),
    };

    public override AbstractDataDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("data_definition_type", out var discProp))
            throw new JsonException("Missing discriminator property \"data_definition_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"data_definition_type\"");
        return ((AbstractDataDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, AbstractDataDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
