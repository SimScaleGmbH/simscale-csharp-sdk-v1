using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define a surface roughness on the wall of the virtual wind tunnel. The roughness value can be defined in two ways: Equivalent sand grain roughness ks. This method is used to represent the actual roughness of specific materials that influence the flow close to the surface. Typical values reach from 0.00005 m for steel to 0.003 m for concrete.Aerodynamic roughness z0. Here, the roughness value is used to model the larger scale effects of non-modeled obstacles (such as vegetation, buildings etc.) on the atmospheric boundary layer flow. Typical values range from 0.0002 m for open sea to 1 m for dense urban areas. The roughness value will only be applied to the floor of the wind tunnel and not to potential terrain surfaces. Learn more.</summary>
[JsonConverter(typeof(OneOf_NoSlipVBCNoSlipWallRoughnessTypeConverter))]
public interface OneOf_NoSlipVBCNoSlipWallRoughnessType { }

internal class OneOf_NoSlipVBCNoSlipWallRoughnessTypeConverter : JsonConverter<OneOf_NoSlipVBCNoSlipWallRoughnessType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NO_SLIP_WALL_EQUIVALENT_SAND_ROUGHNESS"] = typeof(NoSlipWallEquivalentSandRoughness),
        ["NO_SLIP_WALL_AERODYNAMIC_ROUGHNESS"] = typeof(NoSlipWallAerodynamicRoughness),
    };

    public override OneOf_NoSlipVBCNoSlipWallRoughnessType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_NoSlipVBCNoSlipWallRoughnessType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_NoSlipVBCNoSlipWallRoughnessType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
