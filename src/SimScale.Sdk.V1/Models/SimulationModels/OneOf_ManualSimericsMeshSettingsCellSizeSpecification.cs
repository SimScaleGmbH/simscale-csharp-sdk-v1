using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ManualSimericsMeshSettingsCellSizeSpecificationConverter))]
public interface OneOf_ManualSimericsMeshSettingsCellSizeSpecification { }

internal class OneOf_ManualSimericsMeshSettingsCellSizeSpecificationConverter : JsonConverter<OneOf_ManualSimericsMeshSettingsCellSizeSpecification>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["RELATIVE_TO_ALL_CAD_SURFACES"] = typeof(RelativeToAllCadSurfacesSettings),
        ["ABSOLUTE_TO_ALL_CAD_SURFACES"] = typeof(AbsoluteToAllCadSurfacesSettings),
    };

    public override OneOf_ManualSimericsMeshSettingsCellSizeSpecification? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ManualSimericsMeshSettingsCellSizeSpecification?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ManualSimericsMeshSettingsCellSizeSpecification value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
