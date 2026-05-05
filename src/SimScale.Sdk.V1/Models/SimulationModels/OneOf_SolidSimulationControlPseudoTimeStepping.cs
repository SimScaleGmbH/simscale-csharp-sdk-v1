using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SolidSimulationControlPseudoTimeSteppingConverter))]
public interface OneOf_SolidSimulationControlPseudoTimeStepping { }

internal class OneOf_SolidSimulationControlPseudoTimeSteppingConverter : JsonConverter<OneOf_SolidSimulationControlPseudoTimeStepping>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SINGLE_STEP"] = typeof(SingleStepPseudoTimeStepping),
        ["STEPPING_LIST_V18"] = typeof(SteppingListPseudoTimeStepping),
    };

    public override OneOf_SolidSimulationControlPseudoTimeStepping? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidSimulationControlPseudoTimeStepping?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidSimulationControlPseudoTimeStepping value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
