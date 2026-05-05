using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.PostprocessingModels;

[JsonConverter(typeof(OneOfStateAnimationOutputSettingsConverter))]
public interface OneOfStateAnimationOutputSettings { }

internal class OneOfStateAnimationOutputSettingsConverter : JsonConverter<OneOfStateAnimationOutputSettings>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TIME_STEP"] = typeof(StateTimeStepAnimationOutputSettings),
        ["PARTICLE_TRACE"] = typeof(StateParticleTraceAnimationOutputSettings),
        ["SHAPE"] = typeof(StateShapeAnimationOutputSettings),
    };

    public override OneOfStateAnimationOutputSettings? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOfStateAnimationOutputSettings?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOfStateAnimationOutputSettings value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
