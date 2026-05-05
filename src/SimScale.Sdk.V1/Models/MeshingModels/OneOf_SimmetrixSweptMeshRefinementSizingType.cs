using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>Sweep sizing type allows you to specify either the number of elements or the element thickness along the direction of the sweep. The actual absolute thickness will match the desired value as close as possible, given the length of the sweep region as a constraint.</summary>
[JsonConverter(typeof(OneOf_SimmetrixSweptMeshRefinementSizingTypeConverter))]
public interface OneOf_SimmetrixSweptMeshRefinementSizingType { }

internal class OneOf_SimmetrixSweptMeshRefinementSizingTypeConverter : JsonConverter<OneOf_SimmetrixSweptMeshRefinementSizingType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SWEEP_MESHING_ABSOLUTE_SIZE"] = typeof(SweepMeshingAbsoluteSize),
        ["SWEEP_MESHING_NUMBER_OF_ELEMENTS"] = typeof(SweepMeshingNumberOfElements),
    };

    public override OneOf_SimmetrixSweptMeshRefinementSizingType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixSweptMeshRefinementSizingType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixSweptMeshRefinementSizingType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
