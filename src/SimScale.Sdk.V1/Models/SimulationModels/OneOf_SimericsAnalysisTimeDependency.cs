using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Steady-state: Steady-state simulations are time-independent, that is, the equations solved do not include time derivatives. If you are only interested in the converged solution, consider a steady-state simulation.Transient: Transient simulations account for time-dependent effects, that is, the associated flow variables vary with respect to time.</summary>
[JsonConverter(typeof(OneOf_SimericsAnalysisTimeDependencyConverter))]
public interface OneOf_SimericsAnalysisTimeDependency { }

internal class OneOf_SimericsAnalysisTimeDependencyConverter : JsonConverter<OneOf_SimericsAnalysisTimeDependency>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TRANSIENT"] = typeof(TransientTimeDependency),
        ["STATIONARY"] = typeof(StationaryTimeDependency),
    };

    public override OneOf_SimericsAnalysisTimeDependency? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SimericsAnalysisTimeDependency?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SimericsAnalysisTimeDependency value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
