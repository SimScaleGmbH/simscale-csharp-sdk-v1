using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Select the convergence criterion for the nonlinear solution method.Important remarks: When Absolute is selected, the convergence is reached if the maximum absolute residual of a given Newton iteration is lower than the defined tolerance.If Relative is chosen, then the maximum relative residual i.e. the maximum absolute residual divided by external loads and support reactions, is checked during the Newton iteration. Please note that using the Relative criterion leads to a failed convergence if no external load is present (e.g. two far objects coming into contact). In this case, the Adaptive criterion should be used.By selecting the Adaptive option, a combination of both Relative and Absolute criteria is used. That is, in each Newton iteration the Relative is used by default unless the external loads and support reactions have vanished, at which point we check the Absolute one instead.</summary>
[JsonConverter(typeof(OneOf_NewtonResolutionTypeConvergenceCriteriaConverter))]
public interface OneOf_NewtonResolutionTypeConvergenceCriteria { }

internal class OneOf_NewtonResolutionTypeConvergenceCriteriaConverter : JsonConverter<OneOf_NewtonResolutionTypeConvergenceCriteria>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ADAPTIVE"] = typeof(AdaptiveConvergenceCriteria),
        ["RELATIVE"] = typeof(RelativeConvergenceCriteria),
        ["ABSOLUTE"] = typeof(AbsoluteConvergenceCriteria),
    };

    public override OneOf_NewtonResolutionTypeConvergenceCriteria? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_NewtonResolutionTypeConvergenceCriteria?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_NewtonResolutionTypeConvergenceCriteria value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
