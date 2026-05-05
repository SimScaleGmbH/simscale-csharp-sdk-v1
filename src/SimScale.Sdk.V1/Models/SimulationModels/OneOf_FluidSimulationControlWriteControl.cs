using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FluidSimulationControlWriteControlConverter))]
public interface OneOf_FluidSimulationControlWriteControl { }

internal class OneOf_FluidSimulationControlWriteControlConverter : JsonConverter<OneOf_FluidSimulationControlWriteControl>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TIME_STEP"] = typeof(TimeStepWriteControl),
        ["CLOCK_TIME"] = typeof(ClockTimeWriteControl),
        ["RUNTIME"] = typeof(RunTimeWriteControl),
        ["CPU_TIME"] = typeof(CpuTimeWriteControl),
        ["ADJUSTABLE_RUNTIME"] = typeof(AdjustableRuntimeWriteControl),
        ["NUMBER_OF_ITERATIONS_STEADY_STATE"] = typeof(NumberIterationsWriteControl),
    };

    public override OneOf_FluidSimulationControlWriteControl? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FluidSimulationControlWriteControl?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FluidSimulationControlWriteControl value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
