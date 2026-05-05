using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The type of Darcy-Forchheimer porous object defines its directional behaviour.</summary>
[JsonConverter(typeof(OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerTypeConverter))]
public interface OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType { }

internal class OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerTypeConverter : JsonConverter<OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ISOTROPIC"] = typeof(IsotropicDarcyForchheimer),
        ["RECTIFYING"] = typeof(RectifyingDarcyForchheimer),
    };

    public override OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
