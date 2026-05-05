using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_PrandtlLesDeltaDeltaCoefficientConverter))]
public interface OneOf_PrandtlLesDeltaDeltaCoefficient { }

internal class OneOf_PrandtlLesDeltaDeltaCoefficientConverter : JsonConverter<OneOf_PrandtlLesDeltaDeltaCoefficient>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SMOOTH"] = typeof(SmoothLesDelta),
        ["CUBE_ROOT_VOL"] = typeof(CubeRootVolLesDelta),
    };

    public override OneOf_PrandtlLesDeltaDeltaCoefficient? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PrandtlLesDeltaDeltaCoefficient?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PrandtlLesDeltaDeltaCoefficient value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
