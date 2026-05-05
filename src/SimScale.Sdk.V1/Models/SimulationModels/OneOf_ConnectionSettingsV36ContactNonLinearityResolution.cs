using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ConnectionSettingsV36ContactNonLinearityResolutionConverter))]
public interface OneOf_ConnectionSettingsV36ContactNonLinearityResolution { }

internal class OneOf_ConnectionSettingsV36ContactNonLinearityResolutionConverter : JsonConverter<OneOf_ConnectionSettingsV36ContactNonLinearityResolution>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NEWTON"] = typeof(NewtonContactNonLinearityResolution),
        ["FIXED_POINT"] = typeof(FixedPointContactNonLinearityResolution),
    };

    public override OneOf_ConnectionSettingsV36ContactNonLinearityResolution? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ConnectionSettingsV36ContactNonLinearityResolution?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ConnectionSettingsV36ContactNonLinearityResolution value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
