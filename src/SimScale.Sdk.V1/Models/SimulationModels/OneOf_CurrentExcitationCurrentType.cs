using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Constant: Definition of a constant current value. Sinusoidal: Definition of a current that changes sinusoidally with time. Table: Definition of current values at specific time intervals.</summary>
[JsonConverter(typeof(OneOf_CurrentExcitationCurrentTypeConverter))]
public interface OneOf_CurrentExcitationCurrentType { }

internal class OneOf_CurrentExcitationCurrentTypeConverter : JsonConverter<OneOf_CurrentExcitationCurrentType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CURRENT_TYPE_CONSTANT"] = typeof(ElectromagneticCurrentTypeConstant),
        ["CURRENT_TYPE_SINUSOIDAL"] = typeof(ElectromagneticCurrentTypeSinusoidal),
        ["CURRENT_TYPE_TABLE"] = typeof(ElectromagneticCurrentTypeTable),
    };

    public override OneOf_CurrentExcitationCurrentType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CurrentExcitationCurrentType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CurrentExcitationCurrentType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
