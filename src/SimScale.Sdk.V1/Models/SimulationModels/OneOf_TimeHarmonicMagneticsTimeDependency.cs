using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Steady-state: Steady-state simulations are time-independent. That is, the magnetic and thermal field are constant during the simulation.Transient: Transient simulations account for time-dependent effects where the magnetic and thermal field can change with time (e.g. due to Ohmic heating or boundary conditions).</summary>
[JsonConverter(typeof(OneOf_TimeHarmonicMagneticsTimeDependencyConverter))]
public interface OneOf_TimeHarmonicMagneticsTimeDependency { }

internal class OneOf_TimeHarmonicMagneticsTimeDependencyConverter : JsonConverter<OneOf_TimeHarmonicMagneticsTimeDependency>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TRANSIENT"] = typeof(TransientTimeDependency),
        ["STATIONARY"] = typeof(StationaryTimeDependency),
    };

    public override OneOf_TimeHarmonicMagneticsTimeDependency? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_TimeHarmonicMagneticsTimeDependency?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_TimeHarmonicMagneticsTimeDependency value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
