using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

[JsonConverter(typeof(OneOfCameraSettingsConverter))]
public interface OneOfCameraSettings { }

internal class OneOfCameraSettingsConverter : JsonConverter<OneOfCameraSettings>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["USER_INPUT"] = typeof(UserInputCameraSettings),
        ["TOP_VIEW"] = typeof(TopViewPredefinedCameraSettings),
        ["FORTY_FIVE_FORTY_FIVE_VIEW"] = typeof(FortyFiveViewPredefinedCameraSettings),
    };

    public override OneOfCameraSettings? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("settingType", out var discProp))
            throw new JsonException("Missing discriminator property \"settingType\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"settingType\"");
        return ((OneOfCameraSettings?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOfCameraSettings value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
