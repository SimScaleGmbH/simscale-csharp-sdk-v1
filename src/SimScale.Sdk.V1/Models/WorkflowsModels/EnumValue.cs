using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value model for an enum value. Resolves to a text JSON node.</summary>
[JsonConverter(typeof(EnumValueConverter))]
public interface EnumValue { }

internal class EnumValueConverter : JsonConverter<EnumValue>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["enum:constant"] = typeof(EnumConstant),
        ["enum:expression:select"] = typeof(EnumExpressionSelect),
        ["enum:reference"] = typeof(EnumReference),
    };

    public override EnumValue? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("value_model_type", out var discProp))
            throw new JsonException("Missing discriminator property \"value_model_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"value_model_type\"");
        return ((EnumValue?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, EnumValue value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
