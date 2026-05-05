using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the translation behavior between the connected entities along the virtual pin axisFree sliding - bodies may freely translate along the pin axisRigid - translation of the bodies in the pin axis direction is lockedWith axial spring - translation is controlled by an axial spring stiffness, allowing the deformation of the virtual pin itself to affect global deformations</summary>
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
