using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AdvancedROISettingsWindTunnelSizeConverter))]
public interface OneOf_AdvancedROISettingsWindTunnelSize { }

internal class OneOf_AdvancedROISettingsWindTunnelSizeConverter : JsonConverter<OneOf_AdvancedROISettingsWindTunnelSize>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["WIND_TUNNEL_SIZE_MODERATE"] = typeof(WindTunnelSizeModerate),
        ["WIND_TUNNEL_SIZE_LARGE"] = typeof(WindTunnelSizeLarge),
        ["WIND_TUNNEL_SIZE_CUSTOM"] = typeof(WindTunnelSizeCustom),
    };

    public override OneOf_AdvancedROISettingsWindTunnelSize? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedROISettingsWindTunnelSize?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedROISettingsWindTunnelSize value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
