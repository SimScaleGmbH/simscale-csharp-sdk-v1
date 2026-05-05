using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedConceptsSolidBodyMotionsConverter))]
public interface OneOf_AdvancedConceptsSolidBodyMotions { }

internal class OneOf_AdvancedConceptsSolidBodyMotionsConverter : JsonConverter<OneOf_AdvancedConceptsSolidBodyMotions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["LINEAR_MOTION"] = typeof(LinearSBM),
        ["OSCILLATING_ROTATING_MOTION"] = typeof(OscillatingRotatingSBM),
        ["OSCILLATING_LINEAR_MOTION"] = typeof(OscillatingLinearSBM),
        ["ROTATING_MOTION"] = typeof(RotatingSBM),
        ["SHIP_DESIGN_ANALYSIS"] = typeof(ShipDesignAnalysisSBM),
    };

    public override OneOf_AdvancedConceptsSolidBodyMotions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedConceptsSolidBodyMotions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedConceptsSolidBodyMotions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
