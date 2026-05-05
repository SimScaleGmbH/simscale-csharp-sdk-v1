using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

[JsonConverter(typeof(ReportPropertiesConverter))]
public interface ReportProperties { }

internal class ReportPropertiesConverter : JsonConverter<ReportProperties>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ANIMATION"] = typeof(AnimationReportProperties),
        ["SCREENSHOT"] = typeof(ScreenshotReportProperties),
        ["STATISTICS"] = typeof(StatisticsReportProperties),
    };

    public override ReportProperties? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("reportType", out var discProp))
            throw new JsonException("Missing discriminator property \"reportType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"reportType\"");
        return ((ReportProperties?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, ReportProperties value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
