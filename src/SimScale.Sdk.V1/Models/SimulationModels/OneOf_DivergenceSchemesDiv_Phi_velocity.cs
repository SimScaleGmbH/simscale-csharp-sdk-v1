using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option, you can choose your desired divergence scheme.</summary>
[JsonConverter(typeof(OneOf_DivergenceSchemesDiv_Phi_velocityConverter))]
public interface OneOf_DivergenceSchemesDiv_Phi_velocity { }

internal class OneOf_DivergenceSchemesDiv_Phi_velocityConverter : JsonConverter<OneOf_DivergenceSchemesDiv_Phi_velocity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GAUSS_LINEAR"] = typeof(GaussLinearDivergenceScheme),
        ["GAUSS_LINEARUPWINDV_UNLIMITED"] = typeof(GaussLinearUpwindVUnlimitedDivergenceScheme),
        ["GAUSS_LINEARUPWIND_UNLIMITED"] = typeof(GaussLinearUpwindUnlimitedDivergenceScheme),
        ["GAUSS_LINEARUPWIND_LIMITEDGRAD"] = typeof(GaussLinearUpwindLimitedGradDivergenceScheme),
        ["GAUSS_LIMITEDLINEAR_1"] = typeof(GaussLimitedLinear1DivergenceScheme),
        ["GAUSS_LIMITEDLINEARV_1"] = typeof(GaussLimitedLinearV1DivergenceScheme),
        ["BOUNDED_GAUSS_UPWIND"] = typeof(BoundedGaussUpwindDivergenceScheme),
        ["GAUSS_UPWIND"] = typeof(GaussUpwindDivergenceScheme),
        ["GAUSS_VANLEER"] = typeof(GaussVanleerDivergenceScheme),
        ["GAUSS_LINEARUPWINDV_GRAD_U_"] = typeof(GaussLinearUpwindVGradUDivergenceScheme),
    };

    public override OneOf_DivergenceSchemesDiv_Phi_velocity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DivergenceSchemesDiv_Phi_velocity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DivergenceSchemesDiv_Phi_velocity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
