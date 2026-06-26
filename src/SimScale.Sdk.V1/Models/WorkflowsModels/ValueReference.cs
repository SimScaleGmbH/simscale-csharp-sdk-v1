using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Reference to a value which can be resolved using a particular context.</summary>
[JsonConverter(typeof(ValueReferenceConverter))]
public interface ValueReference { }

internal class ValueReferenceConverter : JsonConverter<ValueReference>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["config"] = typeof(ConfigValueReference),
        ["data"] = typeof(DataValueReference),
        ["data_presence"] = typeof(DataPresenceReference),
        ["general_metadata"] = typeof(GeneralMetadataValueReference),
        ["iterator"] = typeof(IteratorReference),
        ["metadata"] = typeof(MetadataValueReference),
    };

    public override ValueReference? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_reference_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_reference_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_reference_type\"");
        return ((ValueReference?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, ValueReference value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
