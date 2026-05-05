using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This parameter determines the fineness of the mesh and affects the overall number of cells. It is recommended to start with the coarse setting. Find out more.Note: This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.</summary>
[JsonConverter(typeof(OneOf_RegionRefinementWindComfortNewFinenessConverter))]
public interface OneOf_RegionRefinementWindComfortNewFineness { }

internal class OneOf_RegionRefinementWindComfortNewFinenessConverter : JsonConverter<OneOf_RegionRefinementWindComfortNewFineness>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["VERY_COARSE"] = typeof(PacefishFinenessVeryCoarse),
        ["COARSE"] = typeof(PacefishFinenessCoarse),
        ["MODERATE"] = typeof(PacefishFinenessModerate),
        ["FINE"] = typeof(PacefishFinenessFine),
        ["VERY_FINE"] = typeof(PacefishFinenessVeryFine),
        ["TARGET_SIZE"] = typeof(PacefishFinenessTargetSize),
    };

    public override OneOf_RegionRefinementWindComfortNewFineness? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_RegionRefinementWindComfortNewFineness?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_RegionRefinementWindComfortNewFineness value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
