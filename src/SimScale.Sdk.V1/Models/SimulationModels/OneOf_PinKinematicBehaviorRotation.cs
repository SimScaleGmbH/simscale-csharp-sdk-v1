using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Rotation about the pin axis, between the parts (Body to body) or against the ground (Body to ground):Free rotation: the parts turn freely, like a hinge.Rigid: rotation is locked.With torsion spring: the Torsion spring stiffness resists the rotation.Note: with Free rotation, a part that is held only by this pin can spin about it, and the solver stops with a singular matrix. Hold the part elsewhere too (a second pin, a contact or a support), or use a soft torsion spring.</summary>
[JsonConverter(typeof(OneOf_PinKinematicBehaviorRotationConverter))]
public interface OneOf_PinKinematicBehaviorRotation { }

internal class OneOf_PinKinematicBehaviorRotationConverter : JsonConverter<OneOf_PinKinematicBehaviorRotation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FREE"] = typeof(FreeAxialRotation),
        ["RIGID"] = typeof(RigidAxialRotation),
        ["TORSIONAL"] = typeof(TorsionalAxialRotation),
    };

    public override OneOf_PinKinematicBehaviorRotation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PinKinematicBehaviorRotation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PinKinematicBehaviorRotation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
