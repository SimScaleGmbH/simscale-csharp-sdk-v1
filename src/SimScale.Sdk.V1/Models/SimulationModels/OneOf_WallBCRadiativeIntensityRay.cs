using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Radiative behaviour of the wall. The Kirchhoff's law of thermal radiation is applied in all options. This means that the absorptivity of the surface is equal to its emissivity. Opaque is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.Transparent is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.Semi-transparent is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.</summary>
[JsonConverter(typeof(OneOf_WallBCRadiativeIntensityRayConverter))]
public interface OneOf_WallBCRadiativeIntensityRay { }

internal class OneOf_WallBCRadiativeIntensityRayConverter : JsonConverter<OneOf_WallBCRadiativeIntensityRay>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["GREYBODY_DIFFUSIVE_RAY"] = typeof(GreybodyDiffusiveRayBC),
        ["OPEN_BOUNDARY_RAY"] = typeof(OpenBoundaryRayBC),
        ["SEMI_OPEN_BOUNDARY_RAY"] = typeof(SemiOpenBoundaryRayBC),
    };

    public override OneOf_WallBCRadiativeIntensityRay? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WallBCRadiativeIntensityRay?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WallBCRadiativeIntensityRay value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
