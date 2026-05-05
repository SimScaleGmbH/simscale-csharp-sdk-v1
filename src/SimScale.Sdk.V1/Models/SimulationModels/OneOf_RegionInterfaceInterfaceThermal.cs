using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_RegionInterfaceInterfaceThermalConverter))]
public interface OneOf_RegionInterfaceInterfaceThermal { }

internal class OneOf_RegionInterfaceInterfaceThermalConverter : JsonConverter<OneOf_RegionInterfaceInterfaceThermal>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["COUPLED"] = typeof(CoupledInterfaceThermal),
        ["ADIABATIC"] = typeof(AdiabaticInterfaceThermal),
        ["TOTAL_RESISTANCE"] = typeof(TotalResistanceInterfaceThermal),
        ["SPECIFIC_CONDUCTANCE"] = typeof(SpecificConductanceInterfaceThermal),
        ["CONTACT_INTERFACE_MATERIAL"] = typeof(ContactInterfaceMaterialInterfaceThermal),
    };

    public override OneOf_RegionInterfaceInterfaceThermal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_RegionInterfaceInterfaceThermal?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_RegionInterfaceInterfaceThermal value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
