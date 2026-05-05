using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for temperature (T).</summary>
[JsonConverter(typeof(OneOf_CustomFluidBCTemperatureConverter))]
public interface OneOf_CustomFluidBCTemperature { }

internal class OneOf_CustomFluidBCTemperatureConverter : JsonConverter<OneOf_CustomFluidBCTemperature>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["EXTERNAL_WALL_HEAT_FLUX_TEMPERATURE"] = typeof(ExternalWallHeatFluxTBC),
        ["FIXED_GRADIENT"] = typeof(FixedGradientTBC),
        ["FIXED_VALUE"] = typeof(FixedValueTBC),
        ["INLET_OUTLET"] = typeof(InletOutletTBC),
        ["ADIABATIC"] = typeof(AdiabaticTBC),
        ["SYMMETRY"] = typeof(SymmetryTBC),
        ["TOTAL_TEMPERATURE"] = typeof(TotalTBC),
        ["TURBULENT_HEAT_FLUX_TEMPERATURE"] = typeof(TurbulentHeatFluxTBC),
        ["WALL_HEAT_TRANSFER"] = typeof(WallHeatTransferTBC),
    };

    public override OneOf_CustomFluidBCTemperature? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CustomFluidBCTemperature?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CustomFluidBCTemperature value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
