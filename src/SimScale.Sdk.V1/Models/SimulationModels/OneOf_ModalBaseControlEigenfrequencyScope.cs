using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select the method to build the modal base, by controlling the search of the natural frequencies: Twice the maximum loading frequency: From zero to twice the maximum excitation frequency defined under Harmonic response.First modes: The first Number of modes will be searched and computed in the order of low to high frequency.Frequency range: All the modes within the specified frequency range will be searched and computed. The frequency range is defined by a Start frequency and an End frequency.Center frequency: Compute the Number of modes closest to the frequency defined by the Center frequency.</summary>
[JsonConverter(typeof(OneOf_ModalBaseControlEigenfrequencyScopeConverter))]
public interface OneOf_ModalBaseControlEigenfrequencyScope { }

internal class OneOf_ModalBaseControlEigenfrequencyScopeConverter : JsonConverter<OneOf_ModalBaseControlEigenfrequencyScope>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TWICE_MAX_LOADING_FREQUENCY"] = typeof(TwiceMaxLoadingFrequency),
        ["FIRSTMODE"] = typeof(FirstMode),
        ["RANGE"] = typeof(FrequencyRange),
        ["CENTER"] = typeof(CenterFrequency),
    };

    public override OneOf_ModalBaseControlEigenfrequencyScope? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ModalBaseControlEigenfrequencyScope?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ModalBaseControlEigenfrequencyScope value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
