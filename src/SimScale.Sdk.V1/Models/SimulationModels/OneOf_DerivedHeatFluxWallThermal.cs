using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This option allows you to model a thin layer resistance on the boundary. Learn more.</summary>
[JsonConverter(typeof(OneOf_DerivedHeatFluxWallThermalConverter))]
public interface OneOf_DerivedHeatFluxWallThermal { }

internal class OneOf_DerivedHeatFluxWallThermalConverter : JsonConverter<OneOf_DerivedHeatFluxWallThermal>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NO_RESISTANCE"] = typeof(NoWallThermal),
        ["TOTAL_RESISTANCE"] = typeof(TotalResistanceWallThermal),
        ["SPECIFIC_CONDUCTANCE"] = typeof(SpecificConductanceWallThermal),
        ["CONTACT_INTERFACE_MATERIAL"] = typeof(LayerWallThermal),
    };

    public override OneOf_DerivedHeatFluxWallThermal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DerivedHeatFluxWallThermal?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DerivedHeatFluxWallThermal value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
