using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Define how to control the overall mesh sizing: Automatic: Element sizing is controlled by automatic fineness levels that take the geometrical properties into account. Manual: Element sizing is controlled by default and minimum size.</summary>
[JsonConverter(typeof(OneOf_SimmetrixMeshingFluidSizingConverter))]
public interface OneOf_SimmetrixMeshingFluidSizing { }

internal class OneOf_SimmetrixMeshingFluidSizingConverter : JsonConverter<OneOf_SimmetrixMeshingFluidSizing>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_V9"] = typeof(AutomaticMeshSizingSimmetrix),
        ["MANUAL"] = typeof(ManualMeshSizingSimmetrix),
    };

    public override OneOf_SimmetrixMeshingFluidSizing? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixMeshingFluidSizing?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixMeshingFluidSizing value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
