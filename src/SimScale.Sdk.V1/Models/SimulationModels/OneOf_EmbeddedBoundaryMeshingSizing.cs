using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define how to control the global mesh sizing: Automatic: Element sizing is controlled by automatic fineness levels that take the geometrical properties into account. Manual: Element sizing is controlled by maximum and minimum edge length. Custom: Element sizing is controlled by the specified number of cells in the three spatial directions and the number refinement levels applied on the surfaces.</summary>
[JsonConverter(typeof(OneOf_EmbeddedBoundaryMeshingSizingConverter))]
public interface OneOf_EmbeddedBoundaryMeshingSizing { }

internal class OneOf_EmbeddedBoundaryMeshingSizingConverter : JsonConverter<OneOf_EmbeddedBoundaryMeshingSizing>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_EBM_MESH_SIZING"] = typeof(AutomaticEmbeddedBoundaryMeshSizing),
        ["MANUAL_EBM_MESH_SIZING"] = typeof(ManualEmbeddedBoundaryMeshSizing),
        ["CUSTOM_EBM_MESH_SIZING"] = typeof(CustomEmbeddedBoundaryMeshSizing),
    };

    public override OneOf_EmbeddedBoundaryMeshingSizing? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_EmbeddedBoundaryMeshingSizing?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_EmbeddedBoundaryMeshingSizing value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
