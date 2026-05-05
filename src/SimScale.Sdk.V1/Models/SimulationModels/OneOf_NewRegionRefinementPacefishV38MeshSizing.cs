using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_NewRegionRefinementPacefishV38MeshSizingConverter))]
public interface OneOf_NewRegionRefinementPacefishV38MeshSizing { }

internal class OneOf_NewRegionRefinementPacefishV38MeshSizingConverter : JsonConverter<OneOf_NewRegionRefinementPacefishV38MeshSizing>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticMeshSizing),
        ["MANUAL_REGION_PACEFISH"] = typeof(ManualRegionSizingPacefish),
    };

    public override OneOf_NewRegionRefinementPacefishV38MeshSizing? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_NewRegionRefinementPacefishV38MeshSizing?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_NewRegionRefinementPacefishV38MeshSizing value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
