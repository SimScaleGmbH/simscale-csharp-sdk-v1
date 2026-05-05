using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Ground reference can be either absolute (uses bottom of region of interest as reference) or relative (uses each assignment as a reference) and elevates those by the height defined. Learn more.</summary>
[JsonConverter(typeof(OneOf_PedestrianComfortSurfaceGroundConverter))]
public interface OneOf_PedestrianComfortSurfaceGround { }

internal class OneOf_PedestrianComfortSurfaceGroundConverter : JsonConverter<OneOf_PedestrianComfortSurfaceGround>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GROUND_ABSOLUTE"] = typeof(GroundAbsolute),
        ["GROUND_RELATIVE"] = typeof(GroundRelative),
    };

    public override OneOf_PedestrianComfortSurfaceGround? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PedestrianComfortSurfaceGround?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PedestrianComfortSurfaceGround value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
