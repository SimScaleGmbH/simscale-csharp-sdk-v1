using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Cauchy stress: Also known as "true stress," it represents the force per unit of current (deformed) area. This is the standard stress measure for large deformation nonlinear analysis. Tensor quantity.Von Mises stress: A scalar value used to predict yielding of ductile materials; it represents the "distortional energy" within the body.Principal stress: The normal stresses acting on planes where the shear stresses are zero (&amp;sigma;1, &amp;sigma;2, &amp;sigma;3), indicating the extreme tension or compression values.</summary>
[JsonConverter(typeof(OneOf_MarcStressFieldSelectionStressTypeConverter))]
public interface OneOf_MarcStressFieldSelectionStressType { }

internal class OneOf_MarcStressFieldSelectionStressTypeConverter : JsonConverter<OneOf_MarcStressFieldSelectionStressType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CAUCHY"] = typeof(MarcCauchyStressType),
        ["VON_MISES"] = typeof(MarcVonMisesStressType),
        ["PRINCIPAL"] = typeof(MarcPrincipalStressType),
    };

    public override OneOf_MarcStressFieldSelectionStressType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcStressFieldSelectionStressType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcStressFieldSelectionStressType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
