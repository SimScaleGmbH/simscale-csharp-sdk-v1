using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

[JsonConverter(typeof(OneOfSimulationRunResultConverter))]
public interface OneOfSimulationRunResult { }

internal class OneOfSimulationRunResultConverter : JsonConverter<OneOfSimulationRunResult>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SOLUTION_FIELD"] = typeof(SimulationRunResultSolution),
        ["CONVERGENCE_PLOT"] = typeof(SimulationRunResultConvergencePlot),
        ["PLOT"] = typeof(SimulationRunResultPlot),
        ["TABLE"] = typeof(SimulationRunResultTable),
    };

    public override OneOfSimulationRunResult? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOfSimulationRunResult?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOfSimulationRunResult value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
