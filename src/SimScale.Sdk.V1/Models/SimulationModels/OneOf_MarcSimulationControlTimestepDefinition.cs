using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose between an automatic and a manual method to define the time increments during the simulation.Automatic: The solver dynamically adjusts the time step size based on convergence behavior and error tolerances. This is recommended for most nonlinear simulations to ensure stability during complex events like contact changes or material yielding.Manual: Specifies a fixed time step size for the duration of the simulation or specific intervals defined via a table. Use this option when the loading rate is constant and well-understood, or when a specific temporal resolution is required regardless of convergence ease. Cut-backs of the time steps are still allowed in case of non-convergence, up to the max number set by the user.</summary>
[JsonConverter(typeof(OneOf_MarcSimulationControlTimestepDefinitionConverter))]
public interface OneOf_MarcSimulationControlTimestepDefinition { }

internal class OneOf_MarcSimulationControlTimestepDefinitionConverter : JsonConverter<OneOf_MarcSimulationControlTimestepDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticTimeStepDefintion),
        ["MANUAL"] = typeof(ManualTimeStepDefintion),
    };

    public override OneOf_MarcSimulationControlTimestepDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcSimulationControlTimestepDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcSimulationControlTimestepDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
