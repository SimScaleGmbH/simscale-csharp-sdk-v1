using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Core losses calculate the losses in magnetic materials, including hysteresis and eddy current losses. Note: Once a core loss model is enabled, eddy currents are suppressed within that body. For more information on each model, please refer to our documentation.</summary>
[JsonConverter(typeof(OneOf_ElectromagneticMaterialCoreLossesTypeConverter))]
public interface OneOf_ElectromagneticMaterialCoreLossesType { }

internal class OneOf_ElectromagneticMaterialCoreLossesTypeConverter : JsonConverter<OneOf_ElectromagneticMaterialCoreLossesType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NONE"] = typeof(NoCoreLoss),
        ["ELECTRICAL_STEEL"] = typeof(ElectricalSteelCoreLoss),
        ["POWER_FERRITE"] = typeof(PowerFerriteCoreLoss),
    };

    public override OneOf_ElectromagneticMaterialCoreLossesType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticMaterialCoreLossesType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticMaterialCoreLossesType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
