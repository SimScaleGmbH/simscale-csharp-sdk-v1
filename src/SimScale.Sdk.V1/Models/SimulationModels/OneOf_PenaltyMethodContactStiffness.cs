using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the stiffness for the contact pair. A higher stiffness reduces interpenetration but may also lead to numerical instabilities and divergence. The independence of the results from this parameter should be checked.</summary>
[JsonConverter(typeof(OneOf_PenaltyMethodContactStiffnessConverter))]
public interface OneOf_PenaltyMethodContactStiffness { }

internal class OneOf_PenaltyMethodContactStiffnessConverter : JsonConverter<OneOf_PenaltyMethodContactStiffness>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["LOW_CONTACT_STIFFNESS"] = typeof(LowContactStiffness),
        ["MODERATE_CONTACT_STIFFNESS"] = typeof(ModerateContactStiffness),
        ["HIGH_CONTACT_STIFFNESS"] = typeof(HighContactStiffness),
        ["CUSTOM_CONTACT_STIFFNESS"] = typeof(CustomContactStiffness),
    };

    public override OneOf_PenaltyMethodContactStiffness? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PenaltyMethodContactStiffness?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PenaltyMethodContactStiffness value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
