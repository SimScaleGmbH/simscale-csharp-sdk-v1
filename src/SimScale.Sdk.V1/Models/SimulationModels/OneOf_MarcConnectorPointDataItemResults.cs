using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>All: Exports all available physical quantities associated with the connector elements for comprehensive tracking - displacements, rotations, forces and moments.Custom: Allows for the selection of specific output variables (like force or displacement) to be recorded at the connector locations.</summary>
[JsonConverter(typeof(OneOf_MarcConnectorPointDataItemResultsConverter))]
public interface OneOf_MarcConnectorPointDataItemResults { }

internal class OneOf_MarcConnectorPointDataItemResultsConverter : JsonConverter<OneOf_MarcConnectorPointDataItemResults>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ALL"] = typeof(AllConnectorPointDataResults),
        ["CUSTOM"] = typeof(CustomConnectorPointDataResults),
    };

    public override OneOf_MarcConnectorPointDataItemResults? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcConnectorPointDataItemResults?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcConnectorPointDataItemResults value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
