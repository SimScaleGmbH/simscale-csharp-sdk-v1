using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SpatialDiscretizationSchemesVolumeOfFluidConverter))]
public interface OneOf_SpatialDiscretizationSchemesVolumeOfFluid { }

internal class OneOf_SpatialDiscretizationSchemesVolumeOfFluidConverter : JsonConverter<OneOf_SpatialDiscretizationSchemesVolumeOfFluid>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["UPWIND_1ST"] = typeof(FirstOrderUpwindSpatialScheme),
        ["UPWIND_2ND"] = typeof(SecondOrderUpwindSpatialScheme),
        ["CENTRAL_DIFFERENCE"] = typeof(CentralDifferenceSpatialScheme),
        ["HIGH_RESOLUTION"] = typeof(HighResolutionSpatialScheme),
    };

    public override OneOf_SpatialDiscretizationSchemesVolumeOfFluid? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SpatialDiscretizationSchemesVolumeOfFluid?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SpatialDiscretizationSchemesVolumeOfFluid value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
