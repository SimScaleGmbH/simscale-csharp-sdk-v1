using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

[JsonConverter(typeof(AlgorithmConverter))]
public interface Algorithm { }

internal class AlgorithmConverter : JsonConverter<Algorithm>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SIMMETRIX_MESHING_FLUID_V16"] = typeof(SimmetrixMeshingFluid),
        ["SIMMETRIX_MESHING_SOLID"] = typeof(SimmetrixMeshingSolid),
        ["SIMMETRIX_MESHING_ELECTROMAGNETICS"] = typeof(SimmetrixMeshingElectromagnetics),
        ["HEX_DOMINANT_SNAPPY_V5"] = typeof(HexDominantSnappy),
        ["POLYGRID_MESHING"] = typeof(PolygridMeshing),
    };

    public override Algorithm? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((Algorithm?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, Algorithm value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
