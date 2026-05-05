using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dielectric strength is the maximum electric field a dielectric material can withstand without electrical breakdown, beyond which it becomes conductive.</summary>
[JsonConverter(typeof(OneOf_ElectromagneticMaterialDielectricStrengthTypeConverter))]
public interface OneOf_ElectromagneticMaterialDielectricStrengthType { }

internal class OneOf_ElectromagneticMaterialDielectricStrengthTypeConverter : JsonConverter<OneOf_ElectromagneticMaterialDielectricStrengthType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NONE"] = typeof(NoDielectricStrength),
        ["ISOTROPIC"] = typeof(IsotropicDielectricStrength),
    };

    public override OneOf_ElectromagneticMaterialDielectricStrengthType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticMaterialDielectricStrengthType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticMaterialDielectricStrengthType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
