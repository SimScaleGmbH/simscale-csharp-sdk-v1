using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The overall conductance (U) of the heat exchanger can be modelled in two different ways:Heat transfer coefficients: In this model the overall conductance (U) is computed using the heat transfer coefficient (h), the surface area density or surface to volume ratio (&amp;rho;) and the exchanger volume (V) as U = h &amp;rho; V. Heat exchanger performance: This model takes the overall conductance (U) as the heat exchanger performance (P).</summary>
[JsonConverter(typeof(OneOf_HeatExchangerSourceHeatExchangerModeConverter))]
public interface OneOf_HeatExchangerSourceHeatExchangerMode { }

internal class OneOf_HeatExchangerSourceHeatExchangerModeConverter : JsonConverter<OneOf_HeatExchangerSourceHeatExchangerMode>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["HEAT_TRANSFER_COEFFICIENTS"] = typeof(HeatTransferCoefficients),
        ["HEAT_EXCHANGER_PERFORMANCE"] = typeof(HeatExchangerPerformance),
    };

    public override OneOf_HeatExchangerSourceHeatExchangerMode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HeatExchangerSourceHeatExchangerMode?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HeatExchangerSourceHeatExchangerMode value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
