using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_StrainFieldSelectionStrainTypeConverter))]
public interface OneOf_StrainFieldSelectionStrainType { }

internal class OneOf_StrainFieldSelectionStrainTypeConverter : JsonConverter<OneOf_StrainFieldSelectionStrainType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL_LINEAR"] = typeof(TotalLinearStrainType),
        ["TOTAL_NONLINEAR"] = typeof(TotalNonLinearStrainType),
        ["TOTAL_EQUI_PLASTIC"] = typeof(TotalEquivalentPlasticStrainType),
        ["UNELASTIC"] = typeof(UnelasticStrainType),
        ["PRINCIPAL"] = typeof(PrincipalStrainType),
        ["PRINCIPAL_GREEN_LAGRANGE"] = typeof(PrincipalGreenLagrangeStrainType),
    };

    public override OneOf_StrainFieldSelectionStrainType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_StrainFieldSelectionStrainType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_StrainFieldSelectionStrainType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
