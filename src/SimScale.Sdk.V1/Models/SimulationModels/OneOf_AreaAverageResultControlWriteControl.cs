using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_AreaAverageResultControlWriteControlConverter))]
public interface OneOf_AreaAverageResultControlWriteControl { }

internal class OneOf_AreaAverageResultControlWriteControlConverter : JsonConverter<OneOf_AreaAverageResultControlWriteControl>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TIME_STEP"] = typeof(TimeStepWriteControl),
        ["OUTPUT_TIME"] = typeof(SynchronizeWithFieldOutputWriteControl),
        ["NUMBER_OF_ITERATIONS_STEADY_STATE"] = typeof(NumberIterationsWriteControl),
    };

    public override OneOf_AreaAverageResultControlWriteControl? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AreaAverageResultControlWriteControl?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AreaAverageResultControlWriteControl value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
