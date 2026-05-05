using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_StrainResultControlItemStrainTypeConverter))]
public interface OneOf_StrainResultControlItemStrainType { }

internal class OneOf_StrainResultControlItemStrainTypeConverter : JsonConverter<OneOf_StrainResultControlItemStrainType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TOTAL_NONLINEAR"] = typeof(GlobalTotalNonlinearStrainType),
        ["TOTAL_EQUI_PLASTIC"] = typeof(GlobalTotalEquivalentPlasticStrainType),
        ["UNELASTIC"] = typeof(GlobalUnelasticStrainType),
        ["TOTAL"] = typeof(GlobalTotalStrainType),
        ["PRINCIPAL"] = typeof(GlobalPrincipalStrainType),
        ["PRINCIPAL_GREEN_LAGRANGE"] = typeof(GlobalPrincipalGreenLagrangeStrainType),
    };

    public override OneOf_StrainResultControlItemStrainType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_StrainResultControlItemStrainType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_StrainResultControlItemStrainType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
