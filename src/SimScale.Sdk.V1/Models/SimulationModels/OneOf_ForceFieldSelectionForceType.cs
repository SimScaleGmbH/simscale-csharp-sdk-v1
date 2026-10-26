using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Reaction force: Reaction forces computed on the nodes of the model. The field is non-zero only on faces with imposed displacement boundary conditions, such as Fixed support, Fixed value, or Symmetry plane. Expressed in global components X, Y, Z.Nodal force: Applied forces as computed on the nodes of the model. The field is non-zero on entities with imposed displacement and load boundary conditions, such as Force, Pressure, etc. Expressed in global components X, Y, Z.</summary>
[JsonConverter(typeof(OneOf_ForceFieldSelectionForceTypeConverter))]
public interface OneOf_ForceFieldSelectionForceType { }

internal class OneOf_ForceFieldSelectionForceTypeConverter : JsonConverter<OneOf_ForceFieldSelectionForceType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["REACTION"] = typeof(ReactionForceType),
        ["NODAL"] = typeof(NodalForceType),
    };

    public override OneOf_ForceFieldSelectionForceType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ForceFieldSelectionForceType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ForceFieldSelectionForceType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
