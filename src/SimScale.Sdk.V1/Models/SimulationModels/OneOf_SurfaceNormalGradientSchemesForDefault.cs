using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>A surface normal gradient is the component, normal to the face, of the gradient of values at the centres of the 2 cells connected through that face. Choose your desired scheme.</summary>
[JsonConverter(typeof(OneOf_SurfaceNormalGradientSchemesForDefaultConverter))]
public interface OneOf_SurfaceNormalGradientSchemesForDefault { }

internal class OneOf_SurfaceNormalGradientSchemesForDefaultConverter : JsonConverter<OneOf_SurfaceNormalGradientSchemesForDefault>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CORRECTED"] = typeof(CorrectedSurfaceNormalGradientScheme),
        ["UNCORRECTED"] = typeof(UncorrectedSurfaceNormalGradientScheme),
        ["LIMITED"] = typeof(LimitedSurfaceNormalGradientScheme),
    };

    public override OneOf_SurfaceNormalGradientSchemesForDefault? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SurfaceNormalGradientSchemesForDefault?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SurfaceNormalGradientSchemesForDefault value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
