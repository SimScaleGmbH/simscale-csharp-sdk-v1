using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_StatisticalAveragingResultControlV2SamplingIntervalConverter))]
public interface OneOf_StatisticalAveragingResultControlV2SamplingInterval { }

internal class OneOf_StatisticalAveragingResultControlV2SamplingIntervalConverter : JsonConverter<OneOf_StatisticalAveragingResultControlV2SamplingInterval>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["HIGH_RESOLUTION"] = typeof(HighResolution),
        ["MODERATE_RESOLUTION"] = typeof(ModerateResolution),
        ["COARSE_RESOLUTION"] = typeof(CoarseResolution),
        ["CUSTOM_RESOLUTION"] = typeof(CustomResolution),
    };

    public override OneOf_StatisticalAveragingResultControlV2SamplingInterval? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_StatisticalAveragingResultControlV2SamplingInterval?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_StatisticalAveragingResultControlV2SamplingInterval value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
