using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Atomic workflow operation which can be executed as is without further decomposition by the workflow engine. It can either refer to a method or a nested workflow.</summary>
[JsonConverter(typeof(AtomicOperationDefinitionConverter))]
public interface AtomicOperationDefinition { }

internal class AtomicOperationDefinitionConverter : JsonConverter<AtomicOperationDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["inline"] = typeof(InlineOperationDefinition),
        ["method"] = typeof(MethodOperationDefinition),
        ["workflow"] = typeof(NestedWorkflowOperationDefinition),
    };

    public override AtomicOperationDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("operation_definition_type", out var discProp))
            throw new JsonException("Missing discriminator property \"operation_definition_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"operation_definition_type\"");
        return ((AtomicOperationDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, AtomicOperationDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
