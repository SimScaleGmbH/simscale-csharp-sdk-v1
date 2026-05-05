using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This determines how the yield surface evolves during cyclic loading; Isotropic expands the surface uniformly, Kinematic shifts it to account for the Bauschinger effect, and Combined utilizes both behaviors for maximum accuracy.</summary>
[JsonConverter(typeof(OneOf_MultilinearModelMarcHardeningRuleConverter))]
public interface OneOf_MultilinearModelMarcHardeningRule { }

internal class OneOf_MultilinearModelMarcHardeningRuleConverter : JsonConverter<OneOf_MultilinearModelMarcHardeningRule>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicPlasticHardeningMarc),
        ["KINEMATIC"] = typeof(KinematicPlasticHardeningMarc),
        ["COMBINED"] = typeof(CombinedPlasticHardeningMarc),
    };

    public override OneOf_MultilinearModelMarcHardeningRule? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MultilinearModelMarcHardeningRule?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MultilinearModelMarcHardeningRule value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
