using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ElectromagneticMotionMotionConverter))]
public interface OneOf_ElectromagneticMotionMotion { }

internal class OneOf_ElectromagneticMotionMotionConverter : JsonConverter<OneOf_ElectromagneticMotionMotion>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PREDEFINED_ROTATIONAL_MOTION"] = typeof(PredefinedRotationalMotion),
        ["PREDEFINED_TRANSLATIONAL_MOTION"] = typeof(PredefinedTranslationalMotion),
        ["COMPUTED_TRANSLATIONAL_MOTION"] = typeof(ComputedTranslationalMotion),
    };

    public override OneOf_ElectromagneticMotionMotion? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticMotionMotion?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticMotionMotion value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
