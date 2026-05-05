using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_HeatTransferBoundaryConditionsConverter))]
public interface OneOf_HeatTransferBoundaryConditions { }

internal class OneOf_HeatTransferBoundaryConditionsConverter : JsonConverter<OneOf_HeatTransferBoundaryConditions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_TEMPERATURE_VALUE"] = typeof(FixedTemperatureValueBC),
        ["CYCLIC_SYMMETRY"] = typeof(CyclicSymmetryBC),
        ["SURFACE_HEAT_FLUX"] = typeof(SurfaceHeatFluxBC),
        ["CONVECTIVE_HEAT_FLUX"] = typeof(ConvectiveHeatFluxBC),
        ["VOLUME_HEAT_FLUX"] = typeof(VolumeHeatFluxBC),
    };

    public override OneOf_HeatTransferBoundaryConditions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HeatTransferBoundaryConditions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HeatTransferBoundaryConditions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
