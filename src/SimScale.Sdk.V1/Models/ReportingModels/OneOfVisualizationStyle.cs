using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

[JsonConverter(typeof(OneOfVisualizationStyleConverter))]
public interface OneOfVisualizationStyle { }

internal class OneOfVisualizationStyleConverter : JsonConverter<OneOfVisualizationStyle>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CYLINDERS"] = typeof(CylindersVisualizationStyle),
        ["SPHERES"] = typeof(SpheresVisualizationStyle),
        ["COMETS"] = typeof(CometsVisualizationStyle),
    };

    public override OneOfVisualizationStyle? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("representation", out var discProp))
            throw new JsonException("Missing discriminator property \"representation\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"representation\"");
        return ((OneOfVisualizationStyle?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOfVisualizationStyle value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
