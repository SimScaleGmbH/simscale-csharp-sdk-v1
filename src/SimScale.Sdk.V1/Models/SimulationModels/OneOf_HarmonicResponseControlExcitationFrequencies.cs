using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Frequencies at which the harmonic loads are to be applied and results are to be computed. Define excitation frequencies using one of the following options: Single frequency : Harmonic loads are applied at one frequency only.Frequency list: Harmonic loads are applied across a range of frequencies with either a constant frequency stepping interval or a variable interval defined via a table.Cluster around modes: Harmonic loads are applied at frequencies clustered around eigenfrequencies.Cover spectrum: Harmonic loads are applied at frequencies clustered around and in between eigenfrequencies to fully capture the entire spectrum.</summary>
[JsonConverter(typeof(OneOf_HarmonicResponseControlExcitationFrequenciesConverter))]
public interface OneOf_HarmonicResponseControlExcitationFrequencies { }

internal class OneOf_HarmonicResponseControlExcitationFrequenciesConverter : JsonConverter<OneOf_HarmonicResponseControlExcitationFrequencies>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SINGLE"] = typeof(SingleFrequency),
        ["LIST_V20"] = typeof(FrequencyList),
        ["CLUSTER_AROUND_MODES"] = typeof(ClusterAroundModes),
        ["COVER_SPECTRUM"] = typeof(CoverSpectrum),
    };

    public override OneOf_HarmonicResponseControlExcitationFrequencies? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HarmonicResponseControlExcitationFrequencies?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HarmonicResponseControlExcitationFrequencies value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
