using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define how gaps and small interferences should be treated:Set Value: Define a numerical distance (tolerance) below which contact is established. If the gap between a contacting node and its target body is larger than the tolerance, the glued contact constraint will not be activated on this node. This check happens on each iteration. For this option the &amp;quot;stress-free projection&amp;quot; of contact nodes on the target surfaces is activated. Small gaps will be closed without adding stresses.Use this option for cases where small CAD inaccuracies, manufacturing tolerances or mesh discretization errors might appear.Off: No specific contact tolerance is used. The program uses an automatic value based on element size (1/10th of the typical element size) to overcome small gaps or penetrations due to mesh approximations on curved surfaces. No &amp;quot;stress-free projection&amp;quot; is active for this setting.</summary>
[JsonConverter(typeof(OneOf_MarcBondedContactConnectionPositionToleranceConverter))]
public interface OneOf_MarcBondedContactConnectionPositionTolerance { }

internal class OneOf_MarcBondedContactConnectionPositionToleranceConverter : JsonConverter<OneOf_MarcBondedContactConnectionPositionTolerance>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SET_VALUE"] = typeof(SetValuePositionTolerance),
        ["OFF"] = typeof(OffPositionTolerance),
    };

    public override OneOf_MarcBondedContactConnectionPositionTolerance? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcBondedContactConnectionPositionTolerance?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcBondedContactConnectionPositionTolerance value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
