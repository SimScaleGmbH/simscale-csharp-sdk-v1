using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_HarmonicResponseResultControlItemFieldSelectionConverter))]
public interface OneOf_HarmonicResponseResultControlItemFieldSelection { }

internal class OneOf_HarmonicResponseResultControlItemFieldSelectionConverter : JsonConverter<OneOf_HarmonicResponseResultControlItemFieldSelection>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DISPLACEMENT"] = typeof(DisplacementFieldSelection),
        ["STRAIN"] = typeof(StrainFieldSelection),
        ["STRESS"] = typeof(StressFieldSelection),
        ["VELOCITY"] = typeof(VelocityFieldSelection),
        ["ACCELERATION"] = typeof(AccelerationFieldSelection),
    };

    public override OneOf_HarmonicResponseResultControlItemFieldSelection? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HarmonicResponseResultControlItemFieldSelection?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HarmonicResponseResultControlItemFieldSelection value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
