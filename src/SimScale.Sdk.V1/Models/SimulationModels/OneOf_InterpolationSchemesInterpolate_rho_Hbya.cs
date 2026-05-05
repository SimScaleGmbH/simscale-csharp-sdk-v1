using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option you can choose your desired interpolation scheme.</summary>
[JsonConverter(typeof(OneOf_InterpolationSchemesInterpolate_rho_HbyaConverter))]
public interface OneOf_InterpolationSchemesInterpolate_rho_Hbya { }

internal class OneOf_InterpolationSchemesInterpolate_rho_HbyaConverter : JsonConverter<OneOf_InterpolationSchemesInterpolate_rho_Hbya>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CUBIC"] = typeof(CubicInterpolationScheme),
        ["LINEAR"] = typeof(LinearInterpolationScheme),
    };

    public override OneOf_InterpolationSchemesInterpolate_rho_Hbya? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_InterpolationSchemesInterpolate_rho_Hbya?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_InterpolationSchemesInterpolate_rho_Hbya value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
