using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Abstract base class for atomic fields.</summary>
[JsonConverter(typeof(AtomicFieldConverter))]
public interface AtomicField { }

internal class AtomicFieldConverter : JsonConverter<AtomicField>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["BooleanField"] = typeof(BooleanField),
        ["IntegerField"] = typeof(IntegerField),
        ["RealField"] = typeof(RealField),
        ["StringField"] = typeof(StringField),
    };

    public override AtomicField? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("schema_element_type", out var discProp))
            throw new JsonException("Missing discriminator property \"schema_element_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"schema_element_type\"");
        return ((AtomicField?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, AtomicField value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
