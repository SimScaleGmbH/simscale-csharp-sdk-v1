using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Use this factor to scale the Reynolds number of your simulation. For example, to change the Reynolds number from 108 to 106, set this factor to 0.01. Learn more.</summary>
[JsonConverter(typeof(OneOf_WindComfortMeshReynoldsScalingTypeConverter))]
public interface OneOf_WindComfortMeshReynoldsScalingType { }

internal class OneOf_WindComfortMeshReynoldsScalingTypeConverter : JsonConverter<OneOf_WindComfortMeshReynoldsScalingType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_REYNOLDS_SCALING"] = typeof(AutomaticReynoldsScaling),
        ["MANUAL_REYNOLDS_SCALING"] = typeof(ManualReynoldsScaling),
    };

    public override OneOf_WindComfortMeshReynoldsScalingType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WindComfortMeshReynoldsScalingType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WindComfortMeshReynoldsScalingType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
