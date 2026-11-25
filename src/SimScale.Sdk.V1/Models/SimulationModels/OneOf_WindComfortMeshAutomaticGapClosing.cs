using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Automatic gap closing has two purposes:Closing gaps: Openings (such as doors or windows) smaller than the Automatic gap closing value are closed. Select Minimum gap size to set the value manually.Memory efficiency: An Automatic gap closing value above the Smallest cell size, typically 4x, greatly reduces memory demand.Note: Make sure openings relevant to the flow are larger than this value.</summary>
[JsonConverter(typeof(OneOf_WindComfortMeshAutomaticGapClosingConverter))]
public interface OneOf_WindComfortMeshAutomaticGapClosing { }

internal class OneOf_WindComfortMeshAutomaticGapClosingConverter : JsonConverter<OneOf_WindComfortMeshAutomaticGapClosing>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SMALLEST_CELL_SIZE"] = typeof(SmallestCell),
        ["MINIMUM_GAP_SIZE"] = typeof(MinimumGapSize),
    };

    public override OneOf_WindComfortMeshAutomaticGapClosing? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WindComfortMeshAutomaticGapClosing?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WindComfortMeshAutomaticGapClosing value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
