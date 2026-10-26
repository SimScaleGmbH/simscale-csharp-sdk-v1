using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The number of superposed Armstrong-Frederick backstress terms used to represent the kinematic hardening. Additional terms allow a more accurate fit of the material's hardening behavior under cyclic and non-proportional loading, at the cost of more material parameters to calibrate.</summary>
[JsonConverter(typeof(OneOf_CombinedVoceChabocheHardeningMarcBackstressTermsConverter))]
public interface OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms { }

internal class OneOf_CombinedVoceChabocheHardeningMarcBackstressTermsConverter : JsonConverter<OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ONE_TERM"] = typeof(OneBackstressTerm),
        ["TWO_TERMS"] = typeof(TwoBackstressTerms),
        ["THREE_TERMS"] = typeof(ThreeBackstressTerms),
    };

    public override OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CombinedVoceChabocheHardeningMarcBackstressTerms value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
