using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the Elasto-plastic model for your problem. Important remarks:Choose Bilinear if the material response is a combination of linear elastic and plastic behavior and is defined by the elastic modulus, yield strength, and, tangent modulus.Choose Multilinear if the material response is a combination of linear elastic-plastic behavior and is defined by the elastic modulus, yield strength, and, multiple tangent moduli.Choose Johnson-Cook if the material response includes strain hardening, strain rate hardening, and thermal softening effects, and is defined by parameters such as yield stress, hardening coefficient, hardening exponent, strain rate hardening coefficient, and thermal softening exponent. Learn more</summary>
[JsonConverter(typeof(OneOf_PlasticMaterialBehaviorElastoPlasticModelConverter))]
public interface OneOf_PlasticMaterialBehaviorElastoPlasticModel { }

internal class OneOf_PlasticMaterialBehaviorElastoPlasticModelConverter : JsonConverter<OneOf_PlasticMaterialBehaviorElastoPlasticModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["BILINEAR"] = typeof(BilinearElastoPlasticModel),
        ["MULTILINEAR"] = typeof(MultilinearElastoPlasticModel),
        ["JOHNSON_COOK"] = typeof(JohnsonCookElastoPlasticModel),
    };

    public override OneOf_PlasticMaterialBehaviorElastoPlasticModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PlasticMaterialBehaviorElastoPlasticModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PlasticMaterialBehaviorElastoPlasticModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
