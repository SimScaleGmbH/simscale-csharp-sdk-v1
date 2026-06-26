using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for an entity assignment list. Resolves to an object node following the [EntityAssignmentList] data model.</summary>
[JsonConverter(typeof(EntityAssignmentListValueConverter))]
public interface EntityAssignmentListValue { }

internal class EntityAssignmentListValueConverter : JsonConverter<EntityAssignmentListValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["entity_assignment:conversion:to_entity_assignment_list"] = typeof(EntityAssignmentToEntityAssignmentListValueConversion),
        ["entity_assignment_list:constant"] = typeof(EntityAssignmentListConstant),
        ["entity_assignment_list:function:intersect"] = typeof(EntityAssignmentListIntersect),
        ["entity_assignment_list:function:map_entities"] = typeof(EntityAssignmentListMapEntities),
        ["entity_assignment_list:reference"] = typeof(EntityAssignmentListReference),
        ["list:conversion:to_entity_assignment_list"] = typeof(EntityAssignmentListFromComponents),
    };

    public override EntityAssignmentListValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((EntityAssignmentListValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, EntityAssignmentListValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
