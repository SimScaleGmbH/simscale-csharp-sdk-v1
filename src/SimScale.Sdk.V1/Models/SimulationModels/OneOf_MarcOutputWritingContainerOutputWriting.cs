using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose how to write the results for the simulation:All computed writes the results for every step. This can lead to a lot of output, especially in simulations with lots of time stepping cutbacks. That takes accordingly longer to post-process.Write interval allows to specify the interval at which results are written.Output steps is used to control the total number of steps for which output is written.</summary>
[JsonConverter(typeof(OneOf_MarcOutputWritingContainerOutputWritingConverter))]
public interface OneOf_MarcOutputWritingContainerOutputWriting { }

internal class OneOf_MarcOutputWritingContainerOutputWritingConverter : JsonConverter<OneOf_MarcOutputWritingContainerOutputWriting>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ALL_COMPUTED"] = typeof(AllComputed),
        ["WRITE_INTERVAL"] = typeof(WriteInterval),
        ["OUTPUT_STEPS"] = typeof(OutputSteps),
    };

    public override OneOf_MarcOutputWritingContainerOutputWriting? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcOutputWritingContainerOutputWriting?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcOutputWritingContainerOutputWriting value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
