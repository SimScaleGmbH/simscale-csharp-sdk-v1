using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Set the frequencies for the harmonic excitation. Setting it to single frequency will only compute harmonic excitation on that frequency. To have harmonic excitations on multiple frequencies, please choose frequency list.</summary>
[JsonConverter(typeof(OneOf_SolidSimulationControlExcitationFrequenciesConverter))]
public interface OneOf_SolidSimulationControlExcitationFrequencies { }

internal class OneOf_SolidSimulationControlExcitationFrequenciesConverter : JsonConverter<OneOf_SolidSimulationControlExcitationFrequencies>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SINGLE"] = typeof(SingleFrequency),
        ["LIST_V20"] = typeof(FrequencyList),
    };

    public override OneOf_SolidSimulationControlExcitationFrequencies? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidSimulationControlExcitationFrequencies?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidSimulationControlExcitationFrequencies value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
