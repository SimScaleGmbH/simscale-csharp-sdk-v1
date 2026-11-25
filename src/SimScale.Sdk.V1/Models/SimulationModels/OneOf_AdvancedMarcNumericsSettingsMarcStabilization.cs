using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Stabilization adds viscous forces that steady the solution, for example in buckling, snap-through, or contact that keeps opening and closing. Marc calls this artificial damping. It only acts with automatic time stepping.Automatic: Damping is added only if the time step reaches the minimum time step, to help the simulation continue.Custom: Damping acts in every increment (damping energy rate method in Marc). It replaces the automatic mode: the time step is then controlled by the damping energy instead of the number of recycles. Damping changes the result while the model is moving, so compare with a run without it.</summary>
[JsonConverter(typeof(OneOf_AdvancedMarcNumericsSettingsMarcStabilizationConverter))]
public interface OneOf_AdvancedMarcNumericsSettingsMarcStabilization { }

internal class OneOf_AdvancedMarcNumericsSettingsMarcStabilizationConverter : JsonConverter<OneOf_AdvancedMarcNumericsSettingsMarcStabilization>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticMarcStabilization),
        ["CUSTOM"] = typeof(CustomMarcStabilization),
    };

    public override OneOf_AdvancedMarcNumericsSettingsMarcStabilization? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedMarcNumericsSettingsMarcStabilization?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedMarcNumericsSettingsMarcStabilization value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
