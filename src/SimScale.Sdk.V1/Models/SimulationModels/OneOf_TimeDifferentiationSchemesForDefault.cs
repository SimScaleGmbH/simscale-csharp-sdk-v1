using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>With this option, you can choose your desired time-differentiation scheme:For steady-state simulations, choose steadyState.Euler is a first-order implicit and bounded scheme. If unsure, try this scheme first.localEuler is a local time-step scheme, which is first-order implicit and bounded.</summary>
[JsonConverter(typeof(OneOf_TimeDifferentiationSchemesForDefaultConverter))]
public interface OneOf_TimeDifferentiationSchemesForDefault { }

internal class OneOf_TimeDifferentiationSchemesForDefaultConverter : JsonConverter<OneOf_TimeDifferentiationSchemesForDefault>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["EULER"] = typeof(EulerTimeDifferentiationScheme),
        ["LOCAL_EULER"] = typeof(LocalEulerTimeDifferentiationScheme),
        ["STEADYSTATE"] = typeof(SteadystateTimeDifferentiationScheme),
    };

    public override OneOf_TimeDifferentiationSchemesForDefault? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_TimeDifferentiationSchemesForDefault?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_TimeDifferentiationSchemesForDefault value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
