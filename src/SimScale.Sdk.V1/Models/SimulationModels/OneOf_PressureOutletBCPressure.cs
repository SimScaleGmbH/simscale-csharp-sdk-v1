using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for pressure (p). Learn more.</summary>
[JsonConverter(typeof(OneOf_PressureOutletBCPressureConverter))]
public interface OneOf_PressureOutletBCPressure { }

internal class OneOf_PressureOutletBCPressureConverter : JsonConverter<OneOf_PressureOutletBCPressure>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_VALUE"] = typeof(FixedValuePBC),
        ["FIXED_MEAN"] = typeof(MeanValuePBC),
    };

    public override OneOf_PressureOutletBCPressure? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PressureOutletBCPressure?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PressureOutletBCPressure value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
