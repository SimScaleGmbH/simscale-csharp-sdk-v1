using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Please choose a boundary condition for phase fraction (alpha).</summary>
[JsonConverter(typeof(OneOf_VelocityOutletBCPhaseFractionConverter))]
public interface OneOf_VelocityOutletBCPhaseFraction { }

internal class OneOf_VelocityOutletBCPhaseFractionConverter : JsonConverter<OneOf_VelocityOutletBCPhaseFraction>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_VALUE"] = typeof(FixedValuePFBC),
        ["FLOW_DEPENDENT_VALUE"] = typeof(FlowDependentValuePFBC),
    };

    public override OneOf_VelocityOutletBCPhaseFraction? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_VelocityOutletBCPhaseFraction?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_VelocityOutletBCPhaseFraction value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
