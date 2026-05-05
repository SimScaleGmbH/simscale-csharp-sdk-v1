using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Constant: Definition of a constant voltage value. Sinusoidal: Definition of a voltage that changes sinusoidally with time. Table: Definition of voltage values at specific time intervals.</summary>
[JsonConverter(typeof(OneOf_VoltageExcitationVoltageTypeConverter))]
public interface OneOf_VoltageExcitationVoltageType { }

internal class OneOf_VoltageExcitationVoltageTypeConverter : JsonConverter<OneOf_VoltageExcitationVoltageType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["VOLTAGE_TYPE_CONSTANT"] = typeof(ElectromagneticVoltageTypeConstant),
        ["VOLTAGE_TYPE_SINUSOIDAL"] = typeof(ElectromagneticVoltageTypeSinusoidal),
        ["VOLTAGE_TYPE_TABLE"] = typeof(ElectromagneticVoltageTypeTable),
    };

    public override OneOf_VoltageExcitationVoltageType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_VoltageExcitationVoltageType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_VoltageExcitationVoltageType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
