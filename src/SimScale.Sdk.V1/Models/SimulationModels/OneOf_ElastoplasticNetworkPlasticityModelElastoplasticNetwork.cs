using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Selecting Arruda-Boyce Plasticity adds a network based on the "eight-chain" statistical model to account for the permanent, rate-independent alignment of molecular chains. This is the preferred choice for modeling the yielding and orientation-hardening behavior of polymers at large strains.</summary>
[JsonConverter(typeof(OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetworkConverter))]
public interface OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork { }

internal class OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetworkConverter : JsonConverter<OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ARRUDA_BOYCE_PLASTIC"] = typeof(ArrudaBoycePlasticElastoplasticNetwork),
        ["OFF"] = typeof(NoElastoplasticity),
    };

    public override OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElastoplasticNetworkPlasticityModelElastoplasticNetwork value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
