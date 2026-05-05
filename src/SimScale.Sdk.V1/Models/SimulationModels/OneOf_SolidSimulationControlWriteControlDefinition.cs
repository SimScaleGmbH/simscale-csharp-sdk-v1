using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SolidSimulationControlWriteControlDefinitionConverter))]
public interface OneOf_SolidSimulationControlWriteControlDefinition { }

internal class OneOf_SolidSimulationControlWriteControlDefinitionConverter : JsonConverter<OneOf_SolidSimulationControlWriteControlDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["WRITE_INTERVAL"] = typeof(WriteIntervalWriteControl),
        ["ALL_COMPUTED"] = typeof(AllComputedWriteControl),
        ["INITIAL"] = typeof(InitialTimestepsWriteControl),
        ["USER_DEFINED_V21"] = typeof(UserDefinedWriteControl),
    };

    public override OneOf_SolidSimulationControlWriteControlDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidSimulationControlWriteControlDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidSimulationControlWriteControlDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
