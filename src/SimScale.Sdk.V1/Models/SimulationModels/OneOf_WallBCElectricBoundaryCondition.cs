using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_WallBCElectricBoundaryConditionConverter))]
public interface OneOf_WallBCElectricBoundaryCondition { }

internal class OneOf_WallBCElectricBoundaryConditionConverter : JsonConverter<OneOf_WallBCElectricBoundaryCondition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NO_CURRENT"] = typeof(NoCurrentEBC),
        ["CURRENT_INFLOW"] = typeof(CurrentInflowEBC),
        ["CURRENT_OUTFLOW"] = typeof(CurrentOutflowEBC),
        ["FIXED_ELECTRIC_POTENTIAL"] = typeof(FixedElectricPotentialEBC),
    };

    public override OneOf_WallBCElectricBoundaryCondition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_WallBCElectricBoundaryCondition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_WallBCElectricBoundaryCondition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
