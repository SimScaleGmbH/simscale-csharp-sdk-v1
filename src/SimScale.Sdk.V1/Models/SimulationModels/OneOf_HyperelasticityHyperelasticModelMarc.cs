using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Mooney: Mooney (or Mooney-Rivlin) is a very common phenomenological model used for modeling the behavior of rubber-like materials at moderate strains (up to ~100%). It is based on a linear combination of two strain invariants, making it computationally stable for simpler elastomeric applications.Ogden: A high-fidelity model that describes the strain energy density as a function of principal stretches rather than invariants. It is highly flexible and capable of capturing complex material behavior at very large strain levels.Marlow: A general-purpose model that allows the strain energy density function to be constructed directly from experimental test data. It is particularly useful when only one type of test data (e.g., uniaxial tension) is available to characterize the material.</summary>
[JsonConverter(typeof(OneOf_HyperelasticityHyperelasticModelMarcConverter))]
public interface OneOf_HyperelasticityHyperelasticModelMarc { }

internal class OneOf_HyperelasticityHyperelasticModelMarcConverter : JsonConverter<OneOf_HyperelasticityHyperelasticModelMarc>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MOONEY_TYPE_MARC"] = typeof(MooneyTypeHyperelasticModelMarc),
        ["OGDEN_MARC"] = typeof(OgdenHyperelasticModelMarc),
        ["MARLOW_MARC"] = typeof(MarlowHyperelasticModelMarc),
    };

    public override OneOf_HyperelasticityHyperelasticModelMarc? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HyperelasticityHyperelasticModelMarc?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HyperelasticityHyperelasticModelMarc value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
