using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option, you can choose your desired gradient scheme:If you are unsure, try Gauss linear first.If you require a higher-order scheme you can use leastSquares.</summary>
[JsonConverter(typeof(OneOf_GradientSchemesGrad_enthalpyConverter))]
public interface OneOf_GradientSchemesGrad_enthalpy { }

internal class OneOf_GradientSchemesGrad_enthalpyConverter : JsonConverter<OneOf_GradientSchemesGrad_enthalpy>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GAUSS_LINEAR"] = typeof(GaussLinearGradientScheme),
        ["CELLLIMITED_GAUSS_LINEAR"] = typeof(CelllimitedGaussLinearGradientScheme),
        ["CELLLIMITED_LEASTSQUARES"] = typeof(CelllimitedLeastSquaresGradientScheme),
        ["FOURTH"] = typeof(FourthGradientScheme),
        ["LEASTSQUARES"] = typeof(LeastsquaresGradientScheme),
    };

    public override OneOf_GradientSchemesGrad_enthalpy? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_GradientSchemesGrad_enthalpy?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_GradientSchemesGrad_enthalpy value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
