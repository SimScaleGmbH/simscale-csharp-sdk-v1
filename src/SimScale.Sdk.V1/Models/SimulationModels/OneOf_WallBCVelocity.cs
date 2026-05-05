using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose the wall boundary condition sub-type based on the wall movement (U). Learn more.</summary>
[JsonConverter(typeof(OneOf_WallBCVelocityConverter))]
public interface OneOf_WallBCVelocity { }

internal class OneOf_WallBCVelocityConverter : JsonConverter<OneOf_WallBCVelocity>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MOVING_WALL_VELOCITY"] = typeof(MovingWallVBC),
        ["NO_SLIP"] = typeof(NoSlipVBC),
        ["ROTATING_WALL_VELOCITY"] = typeof(RotatingWallVBC),
        ["SLIP"] = typeof(SlipVBC),
    };

    public override OneOf_WallBCVelocity? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WallBCVelocity?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WallBCVelocity value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
