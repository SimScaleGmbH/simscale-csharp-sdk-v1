using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

/// <summary>This toggle enables the automatic creation of boundary layers at no-slip walls. When toggled on, the meshing is started together with the simulation run.</summary>
[JsonConverter(typeof(OneOf_SimmetrixMeshingFluidAutomaticLayerSettingsConverter))]
public interface OneOf_SimmetrixMeshingFluidAutomaticLayerSettings { }

internal class OneOf_SimmetrixMeshingFluidAutomaticLayerSettingsConverter : JsonConverter<OneOf_SimmetrixMeshingFluidAutomaticLayerSettings>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_LAYER_ON"] = typeof(AutomaticLayerOn),
        ["AUTOMATIC_LAYER_OFF"] = typeof(AutomaticLayerOff),
    };

    public override OneOf_SimmetrixMeshingFluidAutomaticLayerSettings? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimmetrixMeshingFluidAutomaticLayerSettings?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimmetrixMeshingFluidAutomaticLayerSettings value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
