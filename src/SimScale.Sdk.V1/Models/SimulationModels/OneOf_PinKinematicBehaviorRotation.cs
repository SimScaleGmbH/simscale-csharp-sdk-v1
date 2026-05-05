using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the rotational behavior between the connected entitiesFree rotation - bodies may freely rotate about the pin axisRigid - rotation of the bodies about the pin axis direction is lockedWith torsion spring - rotation is controlled by a torsion spring stiffness</summary>
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
