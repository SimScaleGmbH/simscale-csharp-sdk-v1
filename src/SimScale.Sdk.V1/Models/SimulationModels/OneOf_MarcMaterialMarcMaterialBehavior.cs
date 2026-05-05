using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Linear elastic: This behavior assumes a linear relationship between stress and strain according to Hooke's Law, where the material returns to its original shape upon unloading. It is defined by constant values for Young's modulus and Poisson's ratio and is typically used for materials experiencing small deformations below their yield point.Hyperelastic: Hyperelastic models describe materials like rubber or elastomers that can undergo very large, recoverable (elastic) strains. These models are defined through strain energy functions (e.g., Mooney-Rivlin or Ogden) to capture non-linear elastic behavior and near-incompressibility.Elastoplastic: This behavior models materials that deform elastically until a specific yield stress is reached, after which permanent (plastic) deformation occurs. It utilizes a yield criterion (such as von Mises) and a hardening rule to define how the material's strength increases with continued plastic straining. This behavior is typically used to model materials like metals or structural alloys.Viscoplastic: This multi-network model utilizes a parallel combination of hyperelastic, viscoelastic, and viscoplastic elements to capture the complex, rate-dependent response of polymers like thermoplastics and elastomers. It is specifically designed to simulate phenomena such as creep, stress relaxation, and stiffness degradation (damage) under cyclic loading conditions. It is the ideal choice for thermoplastics and elastomers.</summary>
[JsonConverter(typeof(OneOf_MarcMaterialMarcMaterialBehaviorConverter))]
public interface OneOf_MarcMaterialMarcMaterialBehavior { }

internal class OneOf_MarcMaterialMarcMaterialBehaviorConverter : JsonConverter<OneOf_MarcMaterialMarcMaterialBehavior>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["LINEAR_ELASTIC_MARC"] = typeof(LinearElasticMarcMaterialBehavior),
        ["HYPERELASTIC_MARC"] = typeof(HyperelasticMarcMaterialBehavior),
        ["ELASTOPLASTIC_MARC"] = typeof(ElastoplasticMarcMaterialBehavior),
        ["VISCOPLASTIC_MARC"] = typeof(ViscoplasticMarcMaterialBehavior),
    };

    public override OneOf_MarcMaterialMarcMaterialBehavior? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcMaterialMarcMaterialBehavior?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcMaterialMarcMaterialBehavior value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
