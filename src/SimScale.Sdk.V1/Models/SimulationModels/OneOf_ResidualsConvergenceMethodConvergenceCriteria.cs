using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines whether the tolerances are measured relative to the overall solution, as absolute values, or dynamically adjusted.Relative: Standard for general use. Tolerances are measured as a fraction of the current reference value (e.g., maximum applied force or displacement).Absolute: Necessary when the reference forces are near zero (e.g., free expansion). Tolerances are defined as fixed values in model units.Adaptive: Allows Marc to dynamically loosen or tighten tolerances based on solution progress, balancing robustness and computational efficiency.</summary>
[JsonConverter(typeof(OneOf_ResidualsConvergenceMethodConvergenceCriteriaConverter))]
public interface OneOf_ResidualsConvergenceMethodConvergenceCriteria { }

internal class OneOf_ResidualsConvergenceMethodConvergenceCriteriaConverter : JsonConverter<OneOf_ResidualsConvergenceMethodConvergenceCriteria>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["RELATIVE"] = typeof(RelativeConvergenceResiduals),
        ["ABSOLUTE"] = typeof(AbsoluteConvergenceResiduals),
        ["ADAPTIVE"] = typeof(AdaptiveConvergenceResiduals),
    };

    public override OneOf_ResidualsConvergenceMethodConvergenceCriteria? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ResidualsConvergenceMethodConvergenceCriteria?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ResidualsConvergenceMethodConvergenceCriteria value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
