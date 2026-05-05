using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SolidResultControlAreaCalculationConverter))]
public interface OneOf_SolidResultControlAreaCalculation { }

internal class OneOf_SolidResultControlAreaCalculationConverter : JsonConverter<OneOf_SolidResultControlAreaCalculation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MIN_MAX_FIELDS_CALCULATION"] = typeof(MinMaxFieldsCalculationResultControlItem),
        ["AVERAGE_FIELDS_CALCULATION"] = typeof(AverageFieldsCalculationResultControlItem),
        ["SUM_FIELDS_CALCULATION"] = typeof(SumFieldsCalculationResultControlItem),
        ["HEAT_FLOW_CALCULATION"] = typeof(HeatFlowCalculationResultControlItem),
        ["ERP_CALCULATION"] = typeof(ERPCalculationResultControlItem),
    };

    public override OneOf_SolidResultControlAreaCalculation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidResultControlAreaCalculation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidResultControlAreaCalculation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
