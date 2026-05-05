using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_MarcResultControlSolutionFieldsConverter))]
public interface OneOf_MarcResultControlSolutionFields { }

internal class OneOf_MarcResultControlSolutionFieldsConverter : JsonConverter<OneOf_MarcResultControlSolutionFields>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["DISPLACEMENT"] = typeof(MarcDisplacementResultControlItem),
        ["FORCE"] = typeof(MarcForceResultControlItem),
        ["PRESSURE"] = typeof(MarcPressureResultControlItem),
        ["STRESS"] = typeof(MarcStressResultControlItem),
        ["STRAIN"] = typeof(MarcStrainResultControlItem),
        ["CONTACT"] = typeof(MarcContactResultControlItem),
        ["TEMPERATURE"] = typeof(MarcTemperatureResultControlItem),
        ["HEAT_FLUX"] = typeof(MarcHeatFluxResultControlItem),
    };

    public override OneOf_MarcResultControlSolutionFields? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcResultControlSolutionFields?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcResultControlSolutionFields value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
