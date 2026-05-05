using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option you can choose your desired laplacian scheme.</summary>
[JsonConverter(typeof(OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRateConverter))]
public interface OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate { }

internal class OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRateConverter : JsonConverter<OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GAUSS_LINEAR_CORRECTED"] = typeof(GaussLinearCorrectedLaplacianScheme),
        ["GAUSS_LINEAR_LIMITED_CORRECTED"] = typeof(GaussLinearLimitedCorrectedLaplacianScheme),
        ["GAUSS_LINEAR_UNCORRECTED"] = typeof(GaussLinearUncorrectedLaplacianScheme),
    };

    public override OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_LaplacianSchemesLaplacian_DomegaEff_omegaDissipationRate value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
