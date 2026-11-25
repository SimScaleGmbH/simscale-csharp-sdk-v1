using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_DynamicAnalysisLocalCoordinateSystemsConverter))]
public interface OneOf_DynamicAnalysisLocalCoordinateSystems { }

internal class OneOf_DynamicAnalysisLocalCoordinateSystemsConverter : JsonConverter<OneOf_DynamicAnalysisLocalCoordinateSystems>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CARTESIAN_COORDINATE_SYSTEM"] = typeof(CartesianCoordinateSystem),
        ["CYLINDRICAL_COORDINATE_SYSTEM"] = typeof(CylindricalCoordinateSystem),
    };

    public override OneOf_DynamicAnalysisLocalCoordinateSystems? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DynamicAnalysisLocalCoordinateSystems?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DynamicAnalysisLocalCoordinateSystems value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
