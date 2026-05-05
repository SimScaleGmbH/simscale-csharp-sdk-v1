using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This setting defines how the post-yield behavior is mathematically represented; Bilinear uses a single tangent modulus for simplified hardening, while Multilinear allows for a precise fit of experimental data points.</summary>
[JsonConverter(typeof(OneOf_PlasticityMarcPlasticityModelConverter))]
public interface OneOf_PlasticityMarcPlasticityModel { }

internal class OneOf_PlasticityMarcPlasticityModelConverter : JsonConverter<OneOf_PlasticityMarcPlasticityModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["BILINEAR"] = typeof(BilinearModelMarc),
        ["MULTILINEAR"] = typeof(MultilinearModelMarc),
    };

    public override OneOf_PlasticityMarcPlasticityModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PlasticityMarcPlasticityModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PlasticityMarcPlasticityModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
