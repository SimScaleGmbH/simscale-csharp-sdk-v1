using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define how the distributed mass is specified: either as a total mass that will be distributed across the selected surface, or as an area density that represents mass per unit area.</summary>
[JsonConverter(typeof(OneOf_DistributedMassBCMassDefinitionConverter))]
public interface OneOf_DistributedMassBCMassDefinition { }

internal class OneOf_DistributedMassBCMassDefinitionConverter : JsonConverter<OneOf_DistributedMassBCMassDefinition>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL_MASS"] = typeof(TotalMass),
        ["AREA_DENSITY_MASS"] = typeof(AreaDensityMass),
    };

    public override OneOf_DistributedMassBCMassDefinition? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DistributedMassBCMassDefinition?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DistributedMassBCMassDefinition value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
