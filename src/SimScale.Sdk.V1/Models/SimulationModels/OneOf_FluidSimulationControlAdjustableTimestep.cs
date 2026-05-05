using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FluidSimulationControlAdjustableTimestepConverter))]
public interface OneOf_FluidSimulationControlAdjustableTimestep { }

internal class OneOf_FluidSimulationControlAdjustableTimestepConverter : JsonConverter<OneOf_FluidSimulationControlAdjustableTimestep>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["INACTIVE_TIMESTEP"] = typeof(InactiveAdjustableTimestep),
        ["ACTIVE_TIMESTEP"] = typeof(ActiveAdjustableTimestep),
    };

    public override OneOf_FluidSimulationControlAdjustableTimestep? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FluidSimulationControlAdjustableTimestep?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FluidSimulationControlAdjustableTimestep value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
