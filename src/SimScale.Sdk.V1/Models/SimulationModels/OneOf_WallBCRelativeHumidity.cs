using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_WallBCRelativeHumidityConverter))]
public interface OneOf_WallBCRelativeHumidity { }

internal class OneOf_WallBCRelativeHumidityConverter : JsonConverter<OneOf_WallBCRelativeHumidity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ZERO_GRADIENT"] = typeof(ZeroGradientHumidityBC),
        ["WATER_VAPOR_FLUX"] = typeof(WaterVaporFluxHumidityBC),
        ["SURFACE_WATER_VAPOR_FLUX"] = typeof(SurfaceWaterVaporFluxHumidityBC),
    };

    public override OneOf_WallBCRelativeHumidity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WallBCRelativeHumidity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WallBCRelativeHumidity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
