using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedConceptsPorousMediumsConverter))]
public interface OneOf_AdvancedConceptsPorousMediums { }

internal class OneOf_AdvancedConceptsPorousMediumsConverter : JsonConverter<OneOf_AdvancedConceptsPorousMediums>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DARCY"] = typeof(DarcyMedium),
        ["PRESSURE_LOSS_FUNCTION"] = typeof(PressureLossFunctionMedium),
        ["DARCY_FORCHHEIMER"] = typeof(DarcyForchheimerMedium),
        ["FIXED_COEFFICIENTS"] = typeof(FixedCoeffMedium),
        ["POWER_LAW"] = typeof(PowerLawMedium),
        ["PRESSURE_LOSS_CURVE"] = typeof(PressureLossCurve),
        ["PERFORATED_PLATE"] = typeof(PerforatedPlate),
    };

    public override OneOf_AdvancedConceptsPorousMediums? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedConceptsPorousMediums?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedConceptsPorousMediums value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
