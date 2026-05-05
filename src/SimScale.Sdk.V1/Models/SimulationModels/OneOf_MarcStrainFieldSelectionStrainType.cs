using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Total strain: Represents the sum of all strain components (elastic, plastic, and thermal) relative to the original configuration. It describes the complete deformation state of the material. Tensor quantity.Elastic strain: The recoverable portion of the strain that disappears upon unloading, calculated using the material's elastic constitutive laws. Tensor quantity.Plastic strain: The permanent, non-recoverable deformation that occurs once the material exceeds its yield point. Tensor quantity.Principal strain (total): The strains oriented along the axes where shear strain is zero. These represent the maximum, intermediate, and minimum normal strains in the material. Derived from the total strain tensor field.Principal strain (elastic): The strains oriented along the axes where shear strain is zero. These represent the maximum, intermediate, and minimum normal strains in the material. Derived from the elastic strain tensor field.Principal strain (plastic): The strains oriented along the axes where shear strain is zero. These represent the maximum, intermediate, and minimum normal strains in the material. Derived from the plastic strain tensor field.Equivalent elastic strain: A scalar value derived from the elastic strain tensor components, used to represent the magnitude of elastic deformation in a single value.Equivalent plastic strain: A scalar measure (the von Mises equivalent) representing the accumulation of plastic deformation, often used for assessing material failure or hardening.</summary>
[JsonConverter(typeof(OneOf_MarcStrainFieldSelectionStrainTypeConverter))]
public interface OneOf_MarcStrainFieldSelectionStrainType { }

internal class OneOf_MarcStrainFieldSelectionStrainTypeConverter : JsonConverter<OneOf_MarcStrainFieldSelectionStrainType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL"] = typeof(MarcTotalStrainType),
        ["ELASTIC"] = typeof(MarcElasticStrainType),
        ["PLASTIC"] = typeof(MarcPlasticStrainType),
        ["PRINCIPAL_TOTAL"] = typeof(MarcPrincipalTotalStrainType),
        ["PRINCIPAL_ELASTIC"] = typeof(MarcPrincipalElasticStrainType),
        ["PRINCIPAL_PLASTIC"] = typeof(MarcPrincipalPlasticStrainType),
        ["EQUIVALENT_ELASTIC"] = typeof(MarcEquivalentElasticStrainType),
        ["EQUIVALENT_PLASTIC"] = typeof(MarcEquivalentPlasticStrainType),
    };

    public override OneOf_MarcStrainFieldSelectionStrainType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcStrainFieldSelectionStrainType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcStrainFieldSelectionStrainType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
