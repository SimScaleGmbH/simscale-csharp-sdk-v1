using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Movement along the pin axis, between the parts (Body to body) or against the ground (Body to ground):Free sliding: the parts slide freely along the pin.Rigid: sliding is locked.With axial spring: the Axial spring stiffness resists the sliding.Note: with Free sliding, a part that is held only by this pin can move along the axis, and the solver stops with a singular matrix. A contact alone often does not hold it. Hold the part elsewhere, or use a soft axial spring (e.g. 10 N/m).</summary>
[JsonConverter(typeof(OneOf_PinKinematicBehaviorAxialTranslationConverter))]
public interface OneOf_PinKinematicBehaviorAxialTranslation { }

internal class OneOf_PinKinematicBehaviorAxialTranslationConverter : JsonConverter<OneOf_PinKinematicBehaviorAxialTranslation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FREE"] = typeof(FreeAxialTranslation),
        ["RIGID"] = typeof(RigidAxialTranslation),
        ["FLEXIBLE"] = typeof(FlexibleAxialTranslation),
    };

    public override OneOf_PinKinematicBehaviorAxialTranslation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PinKinematicBehaviorAxialTranslation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PinKinematicBehaviorAxialTranslation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
