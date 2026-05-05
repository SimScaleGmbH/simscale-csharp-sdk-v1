using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select how you want to control natural frequencies to be computed: First modes: The first Number of modes will be searched and computed, in the order of low to high frequency.Frequency range: All the modes within the range of frequencies will be searched and computed. The frequency range is specified by a Start frequency and an End frequency.Center frequency: Compute the Number of modes closest to the frequency defined by Center frequency.</summary>
[JsonConverter(typeof(OneOf_SolidSimulationControlEigenfrequencyScopeConverter))]
public interface OneOf_SolidSimulationControlEigenfrequencyScope { }

internal class OneOf_SolidSimulationControlEigenfrequencyScopeConverter : JsonConverter<OneOf_SolidSimulationControlEigenfrequencyScope>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIRSTMODE"] = typeof(FirstMode),
        ["RANGE"] = typeof(FrequencyRange),
        ["CENTER"] = typeof(CenterFrequency),
    };

    public override OneOf_SolidSimulationControlEigenfrequencyScope? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidSimulationControlEigenfrequencyScope?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidSimulationControlEigenfrequencyScope value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
