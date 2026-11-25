using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Whether the body is stopped once it has moved a certain distance, the way a real actuator hits an end stop.None &amp;mdash; the motion is unbounded. A body with no spring holding it back will keep accelerating until it leaves the simulated region.Distance &amp;mdash; set how far the body may travel in each direction.</summary>
[JsonConverter(typeof(OneOf_MotionAxisTravelLimitConverter))]
public interface OneOf_MotionAxisTravelLimit { }

internal class OneOf_MotionAxisTravelLimitConverter : JsonConverter<OneOf_MotionAxisTravelLimit>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NO_TRAVEL_LIMIT"] = typeof(NoTravelLimit),
        ["TRAVEL_DISTANCE"] = typeof(TravelDistance),
    };

    public override OneOf_MotionAxisTravelLimit? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MotionAxisTravelLimit?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MotionAxisTravelLimit value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
