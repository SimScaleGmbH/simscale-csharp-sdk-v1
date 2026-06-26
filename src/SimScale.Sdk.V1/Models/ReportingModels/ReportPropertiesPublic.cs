using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Public counterpart of ReportProperties whose STATISTICS variant omits the server-resolved resolution hints (cadAssociations, topologyLabelByName). Used by the public ReportResponse; the report request and the internal report representation use ReportProperties, which carries those fields.</summary>
[JsonConverter(typeof(ReportPropertiesPublicConverter))]
public interface ReportPropertiesPublic { }

internal class ReportPropertiesPublicConverter : JsonConverter<ReportPropertiesPublic>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ANIMATION"] = typeof(AnimationReportProperties),
        ["SCREENSHOT"] = typeof(ScreenshotReportProperties),
        ["STATISTICS"] = typeof(StatisticsReportPropertiesPublic),
    };

    public override ReportPropertiesPublic? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("reportType", out var discProp))
            throw new JsonException("Missing discriminator property \"reportType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"reportType\"");
        return ((ReportPropertiesPublic?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, ReportPropertiesPublic value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
