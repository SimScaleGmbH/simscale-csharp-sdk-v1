using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Normal force: The compressive force acting perpendicular to the contact interface between two bodies.Friction force: The tangential shear force generated at a contact interface that resists relative sliding between two bodies due to friction.Contact body force: Computes the total resultant force vector acting on a specific body due to all its active contact interactions. Available in volume sum only.</summary>
[JsonConverter(typeof(OneOf_MarcContactForceFieldSelectionContactTypeConverter))]
public interface OneOf_MarcContactForceFieldSelectionContactType { }

internal class OneOf_MarcContactForceFieldSelectionContactTypeConverter : JsonConverter<OneOf_MarcContactForceFieldSelectionContactType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NORMAL_FORCE"] = typeof(MarcContactNormalForceType),
        ["FRICTION_FORCE"] = typeof(MarcContactFrictionForceType),
        ["BODY_FORCE"] = typeof(MarcContactBodyForceType),
    };

    public override OneOf_MarcContactForceFieldSelectionContactType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcContactForceFieldSelectionContactType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcContactForceFieldSelectionContactType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
