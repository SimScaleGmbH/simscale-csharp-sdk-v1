using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Current ExcitationUse when you want to set a specific current flow through the coil. Note that the specified current is assumed to flow over the sum of all entry (or internal) faces.Voltage ExcitationUse when you want to set a specific voltage across the coil ports.</summary>
[JsonConverter(typeof(OneOf_CoilExcitationConverter))]
public interface OneOf_CoilExcitation { }

internal class OneOf_CoilExcitationConverter : JsonConverter<OneOf_CoilExcitation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CURRENT_EXCITATION"] = typeof(CurrentExcitation),
        ["VOLTAGE_EXCITATION"] = typeof(VoltageExcitation),
    };

    public override OneOf_CoilExcitation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CoilExcitation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CoilExcitation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
