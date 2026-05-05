using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the direction for applying fluid resistance: Allowed: Fluid resistance is applied in the chosen direction, while fluid flow is blocked in the other two orthogonal directions. Blocked: Fluid flow is blocked in the chosen direction, and fluid resistance is applied in the other two orthogonal directions.</summary>
[JsonConverter(typeof(OneOf_DirectionalMaterialStructureModeConverter))]
public interface OneOf_DirectionalMaterialStructureMode { }

internal class OneOf_DirectionalMaterialStructureModeConverter : JsonConverter<OneOf_DirectionalMaterialStructureMode>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ALLOWED_DIRECTION"] = typeof(AllowedDirection),
        ["BLOCKED_DIRECTION"] = typeof(BlockedDirection),
    };

    public override OneOf_DirectionalMaterialStructureMode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DirectionalMaterialStructureMode?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DirectionalMaterialStructureMode value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
