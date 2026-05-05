using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Normal force: The compressive force acting perpendicular to the contact interface between two bodies.Friction force: The tangential shear force generated at a contact interface that resists relative sliding between two bodies due to friction.Normal stress: The contact pressure distributed over the interface area, acting perpendicular to the surfaces.Friction stress: The shear stress distributed over the contact interface resulting from friction.Gap: The physical distance between two potential contact surfaces; a value of zero (or a very small tolerance) indicates the surfaces are in contact.State: A status indicator showing whether a contact pair is open (no contact), closed (sticking), or sliding.Pressure: The magnitude of the normal compressive stress exerted by one body onto another at the contact interface.</summary>
[JsonConverter(typeof(OneOf_MarcContactResultControlItemContactTypeConverter))]
public interface OneOf_MarcContactResultControlItemContactType { }

internal class OneOf_MarcContactResultControlItemContactTypeConverter : JsonConverter<OneOf_MarcContactResultControlItemContactType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NORMAL_FORCE"] = typeof(MarcContactNormalForce),
        ["FRICTION_FORCE"] = typeof(MarcContactFrictionForce),
        ["NORMAL_STRESS"] = typeof(MarcContactNormalStress),
        ["FRICTION_STRESS"] = typeof(MarcContactFrictionStress),
        ["GAP"] = typeof(MarcContactGap),
        ["STATUS"] = typeof(MarcContactStatus),
        ["PRESSURE"] = typeof(MarcContactPressure),
    };

    public override OneOf_MarcContactResultControlItemContactType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcContactResultControlItemContactType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcContactResultControlItemContactType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
