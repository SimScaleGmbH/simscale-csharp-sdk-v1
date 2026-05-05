using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_PacefishAutomeshRefinementsConverter))]
public interface OneOf_PacefishAutomeshRefinements { }

internal class OneOf_PacefishAutomeshRefinementsConverter : JsonConverter<OneOf_PacefishAutomeshRefinements>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["REGION_PACEFISH_V38"] = typeof(NewRegionRefinementPacefishV38),
        ["SURFACE_PACEFISH_V38"] = typeof(NewSurfaceRefinementPacefishV38),
    };

    public override OneOf_PacefishAutomeshRefinements? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PacefishAutomeshRefinements?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PacefishAutomeshRefinements value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
