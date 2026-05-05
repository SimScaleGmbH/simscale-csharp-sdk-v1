using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AverageFieldsCalculationResultControlItemFieldSelectionConverter))]
public interface OneOf_AverageFieldsCalculationResultControlItemFieldSelection { }

internal class OneOf_AverageFieldsCalculationResultControlItemFieldSelectionConverter : JsonConverter<OneOf_AverageFieldsCalculationResultControlItemFieldSelection>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DISPLACEMENT"] = typeof(DisplacementFieldSelection),
        ["FORCE"] = typeof(ForceFieldSelection),
        ["CONTACT"] = typeof(ContactFieldSelection),
        ["STRAIN"] = typeof(StrainFieldSelection),
        ["STRESS"] = typeof(StressFieldSelection),
        ["VELOCITY"] = typeof(VelocityFieldSelection),
        ["ACCELERATION"] = typeof(AccelerationFieldSelection),
        ["TEMPERATURE"] = typeof(TemperatureFieldSelection),
        ["HEAT_FLUX"] = typeof(HeatFluxFieldSelection),
    };

    public override OneOf_AverageFieldsCalculationResultControlItemFieldSelection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AverageFieldsCalculationResultControlItemFieldSelection?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AverageFieldsCalculationResultControlItemFieldSelection value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
