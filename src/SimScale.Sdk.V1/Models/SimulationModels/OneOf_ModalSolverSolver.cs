using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose a linear equation system solver for your calculation:Multfront is a direct solver of the multifrontal type. It is easy to set up and behaves well for most problems.MUMPS is a general purpose direct solver of the multifrontal type. It provides a lot of parameter settings to allow the best fitting to your problems needs.</summary>
[JsonConverter(typeof(OneOf_ModalSolverSolverConverter))]
public interface OneOf_ModalSolverSolver { }

internal class OneOf_ModalSolverSolverConverter : JsonConverter<OneOf_ModalSolverSolver>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MUMPS"] = typeof(MUMPSSolver),
        ["MULTIFRONT"] = typeof(MultifrontalSolver),
    };

    public override OneOf_ModalSolverSolver? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ModalSolverSolver?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ModalSolverSolver value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
