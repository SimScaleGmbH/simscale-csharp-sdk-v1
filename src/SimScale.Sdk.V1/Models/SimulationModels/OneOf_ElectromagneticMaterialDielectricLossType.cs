using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify the dielectric loss type. It models dielectric heating losses in insulating materials under time-varying electric fields. For details, see our documentation.</summary>
[JsonConverter(typeof(OneOf_ElectromagneticMaterialDielectricLossTypeConverter))]
public interface OneOf_ElectromagneticMaterialDielectricLossType { }

internal class OneOf_ElectromagneticMaterialDielectricLossTypeConverter : JsonConverter<OneOf_ElectromagneticMaterialDielectricLossType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NONE"] = typeof(NoDielectricLosses),
        ["ISOTROPIC_LOSS_TANGENT"] = typeof(IsotropicLossTangent),
    };

    public override OneOf_ElectromagneticMaterialDielectricLossType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticMaterialDielectricLossType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticMaterialDielectricLossType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
