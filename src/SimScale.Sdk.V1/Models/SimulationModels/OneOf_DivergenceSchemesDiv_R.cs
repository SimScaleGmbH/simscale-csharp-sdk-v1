using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option, you can choose your desired divergence scheme.</summary>
[JsonConverter(typeof(OneOf_DivergenceSchemesDiv_RConverter))]
public interface OneOf_DivergenceSchemesDiv_R { }

internal class OneOf_DivergenceSchemesDiv_RConverter : JsonConverter<OneOf_DivergenceSchemesDiv_R>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GAUSS_LINEAR"] = typeof(GaussLinearDivergenceScheme),
        ["GAUSS_LINEARUPWINDV_UNLIMITED"] = typeof(GaussLinearUpwindVUnlimitedDivergenceScheme),
    };

    public override OneOf_DivergenceSchemesDiv_R? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DivergenceSchemesDiv_R?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DivergenceSchemesDiv_R value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
