using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Add a surface roughness to the selected surfaces. Three different options are available: Equivalent sand grain roughness ks. This method is used to represent the actual roughness of specific materials that influence the flow close to the surface. Typical values reach from 0.00005 m for steel to 0.003 m for concrete.Aerodynamic roughness z0. Here, the roughness value is used to model the larger scale effects of non-modeled obstacles (such as vegetation, buildings etc.) on the Atmospheric Boundary Layer (ABL) flow. Typical values range from 0.0002 m for open sea to 1 m for dense urban areas.From wind exposure (only PWC). Here, the aerodynamic roughness value is automatically selected based on the selected wind exposure category for each wind direction individually. For the exact values of the aerodynamic roughness used, depending on the wind engineering standard, you can refer to this documentation page. This method is preferred in order to achieve horizontal homogeneity for the incoming ABL flow.. Learn more.</summary>
[JsonConverter(typeof(OneOf_SurfaceRoughnessModelSurfaceRoughnessTypeConverter))]
public interface OneOf_SurfaceRoughnessModelSurfaceRoughnessType { }

internal class OneOf_SurfaceRoughnessModelSurfaceRoughnessTypeConverter : JsonConverter<OneOf_SurfaceRoughnessModelSurfaceRoughnessType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["EQUIVALENT_SAND_GRAIN_ROUGHNESS"] = typeof(EquivalentSandGrainRoughness),
        ["AERODYNAMIC_ROUGHNESS"] = typeof(AerodynamicRoughness),
        ["WIND_EXPOSURE_ROUGHNESS"] = typeof(WindExposureRoughness),
    };

    public override OneOf_SurfaceRoughnessModelSurfaceRoughnessType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SurfaceRoughnessModelSurfaceRoughnessType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SurfaceRoughnessModelSurfaceRoughnessType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
