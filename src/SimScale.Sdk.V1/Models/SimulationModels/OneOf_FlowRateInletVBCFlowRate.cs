using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FlowRateInletVBCFlowRateConverter))]
public interface OneOf_FlowRateInletVBCFlowRate { }

internal class OneOf_FlowRateInletVBCFlowRateConverter : JsonConverter<OneOf_FlowRateInletVBCFlowRate>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MASS"] = typeof(MassFlow),
        ["VOLUMETRIC"] = typeof(VolumetricFlow),
    };

    public override OneOf_FlowRateInletVBCFlowRate? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FlowRateInletVBCFlowRate?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FlowRateInletVBCFlowRate value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
