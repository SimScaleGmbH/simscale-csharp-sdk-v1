using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This determines which hardening mechanisms are active for the Voce-Chaboche model; Isotropic expands the yield surface uniformly following a Voce saturation law, Kinematic translates it via one or more superposed Armstrong-Frederick backstresses to capture the Bauschinger effect, and Combined uses both.</summary>
[JsonConverter(typeof(OneOf_VoceChabocheModelMarcHardeningRuleConverter))]
public interface OneOf_VoceChabocheModelMarcHardeningRule { }

internal class OneOf_VoceChabocheModelMarcHardeningRuleConverter : JsonConverter<OneOf_VoceChabocheModelMarcHardeningRule>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicVoceHardeningMarc),
        ["KINEMATIC"] = typeof(KinematicChabocheHardeningMarc),
        ["COMBINED"] = typeof(CombinedVoceChabocheHardeningMarc),
    };

    public override OneOf_VoceChabocheModelMarcHardeningRule? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_VoceChabocheModelMarcHardeningRule?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_VoceChabocheModelMarcHardeningRule value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
