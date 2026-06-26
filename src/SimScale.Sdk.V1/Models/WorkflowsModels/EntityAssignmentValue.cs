using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for an entity assignment. Resolves to an object node following the [EntityAssignment] data model.</summary>
[JsonConverter(typeof(EntityAssignmentValueConverter))]
public interface EntityAssignmentValue { }

internal class EntityAssignmentValueConverter : JsonConverter<EntityAssignmentValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["entity_assignment:constant"] = typeof(EntityAssignmentConstant),
        ["entity_assignment:function:map_entities"] = typeof(EntityAssignmentMapEntities),
        ["entity_assignment:reference"] = typeof(EntityAssignmentReference),
    };

    public override EntityAssignmentValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((EntityAssignmentValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, EntityAssignmentValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
