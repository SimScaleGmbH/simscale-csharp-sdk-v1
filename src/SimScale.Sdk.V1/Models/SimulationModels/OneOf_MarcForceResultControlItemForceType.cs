using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Reaction force: The forces exerted by constraints (supports) to prevent motion; the sum of reaction forces typically balances the total external load.External force: The nodal representation of all applied loads, such as point loads and distributed loads, acting on the structure.</summary>
[JsonConverter(typeof(OneOf_MarcForceResultControlItemForceTypeConverter))]
public interface OneOf_MarcForceResultControlItemForceType { }

internal class OneOf_MarcForceResultControlItemForceTypeConverter : JsonConverter<OneOf_MarcForceResultControlItemForceType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["REACTION"] = typeof(ReactionForce),
        ["EXTERNAL"] = typeof(ExternalForce),
    };

    public override OneOf_MarcForceResultControlItemForceType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcForceResultControlItemForceType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcForceResultControlItemForceType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
