using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

[JsonConverter(typeof(ReportFromStatePropertiesConverter))]
public interface ReportFromStateProperties { }

internal class ReportFromStatePropertiesConverter : JsonConverter<ReportFromStateProperties>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ANIMATION"] = typeof(AnimationReportFromStateProperties),
        ["SCREENSHOT"] = typeof(ScreenshotReportFromStateProperties),
    };

    public override ReportFromStateProperties? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("reportType", out var discProp))
            throw new JsonException("Missing discriminator property \"reportType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"reportType\"");
        return ((ReportFromStateProperties?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, ReportFromStateProperties value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
