using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_IncompressibleMaterialViscosityModelConverter))]
public interface OneOf_IncompressibleMaterialViscosityModel { }

internal class OneOf_IncompressibleMaterialViscosityModelConverter : JsonConverter<OneOf_IncompressibleMaterialViscosityModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NEWTONIAN"] = typeof(NewtonianViscosityModel),
        ["POWER_LAW"] = typeof(PowerLawViscosityModel),
        ["STD_HERSCHEL_BULKLEY"] = typeof(StandardHerschelBulkleyViscosityModel),
        ["HERSCHEL_BULKLEY"] = typeof(HerschelBulkleyViscosityModel),
        ["CROSS_POWER_LAW"] = typeof(CrossPowerLawViscosityModel),
        ["BIRD_CARREAU"] = typeof(BirdCarreauViscosityModel),
    };

    public override OneOf_IncompressibleMaterialViscosityModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_IncompressibleMaterialViscosityModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_IncompressibleMaterialViscosityModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
