using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The fraction of body exposed to radiation (feff) refers to the portion of the body in the range [0, 1] exposed to direct solar radiation (e.g. 0.696 for a seated person and 0.725 for a standing person)</summary>
[JsonConverter(typeof(OneOf_MrtSolarParametersFractionBodySurfaceConverter))]
public interface OneOf_MrtSolarParametersFractionBodySurface { }

internal class OneOf_MrtSolarParametersFractionBodySurfaceConverter : JsonConverter<OneOf_MrtSolarParametersFractionBodySurface>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SITTING_FRACTION_BODY_SURFACE"] = typeof(SittingFractionBodySurface),
        ["STANDING_FRACTION_BODY_SURFACE"] = typeof(StandingFractionBodySurface),
        ["CUSTOM_FRACTION_BODY_SURFACE"] = typeof(CustomFractionBodySurface),
    };

    public override OneOf_MrtSolarParametersFractionBodySurface? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MrtSolarParametersFractionBodySurface?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MrtSolarParametersFractionBodySurface value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
