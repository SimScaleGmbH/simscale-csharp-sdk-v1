using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_MarcAnalysisBoundaryConditionsConverter))]
public interface OneOf_MarcAnalysisBoundaryConditions { }

internal class OneOf_MarcAnalysisBoundaryConditionsConverter : JsonConverter<OneOf_MarcAnalysisBoundaryConditions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FIXED_VALUE"] = typeof(FixedValueBCMarc),
        ["PRESSURE"] = typeof(PressureBCMarc),
        ["SYMMETRY"] = typeof(SymmetryBCMarc),
        ["POINT_DISPLACEMENT"] = typeof(PointDisplacementBCMarc),
        ["POINT_LOAD"] = typeof(PointLoadBCMarc),
        ["TEMPERATURE"] = typeof(TemperatureBCMarc),
    };

    public override OneOf_MarcAnalysisBoundaryConditions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcAnalysisBoundaryConditions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcAnalysisBoundaryConditions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
