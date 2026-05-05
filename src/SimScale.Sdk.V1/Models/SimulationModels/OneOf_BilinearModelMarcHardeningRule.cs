using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This determines how the yield surface evolves during cyclic loading; Isotropic expands the surface uniformly, Kinematic shifts it to account for the Bauschinger effect, and Combined utilizes both behaviors for maximum accuracy.</summary>
[JsonConverter(typeof(OneOf_BilinearModelMarcHardeningRuleConverter))]
public interface OneOf_BilinearModelMarcHardeningRule { }

internal class OneOf_BilinearModelMarcHardeningRuleConverter : JsonConverter<OneOf_BilinearModelMarcHardeningRule>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicPlasticHardeningMarc),
        ["KINEMATIC"] = typeof(KinematicPlasticHardeningMarc),
        ["COMBINED"] = typeof(CombinedPlasticHardeningMarc),
    };

    public override OneOf_BilinearModelMarcHardeningRule? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_BilinearModelMarcHardeningRule?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_BilinearModelMarcHardeningRule value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
