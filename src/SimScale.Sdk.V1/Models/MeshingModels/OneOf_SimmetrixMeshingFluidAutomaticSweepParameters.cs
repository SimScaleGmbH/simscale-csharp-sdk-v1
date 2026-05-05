using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>This toggle enables the automatic detection and meshing of sweepable bodies.</summary>
[JsonConverter(typeof(OneOf_SimmetrixMeshingFluidAutomaticSweepParametersConverter))]
public interface OneOf_SimmetrixMeshingFluidAutomaticSweepParameters { }

internal class OneOf_SimmetrixMeshingFluidAutomaticSweepParametersConverter : JsonConverter<OneOf_SimmetrixMeshingFluidAutomaticSweepParameters>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_SWEEP_MESHING_ON"] = typeof(AutomaticSweepOn),
        ["AUTOMATIC_SWEEP_MESHING_OFF"] = typeof(AutomaticSweepOff),
    };

    public override OneOf_SimmetrixMeshingFluidAutomaticSweepParameters? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixMeshingFluidAutomaticSweepParameters?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixMeshingFluidAutomaticSweepParameters value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
