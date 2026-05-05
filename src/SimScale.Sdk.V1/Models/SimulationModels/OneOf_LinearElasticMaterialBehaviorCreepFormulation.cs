using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the Creep formulation. Three different formulations are available: Norton, Strain Hardening or Time Hardening.They are based on the Power Law:&amp;epsilon;&amp;#775 = m*A*&amp;sigma;n*tm-1</summary>
[JsonConverter(typeof(OneOf_LinearElasticMaterialBehaviorCreepFormulationConverter))]
public interface OneOf_LinearElasticMaterialBehaviorCreepFormulation { }

internal class OneOf_LinearElasticMaterialBehaviorCreepFormulationConverter : JsonConverter<OneOf_LinearElasticMaterialBehaviorCreepFormulation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["NORTON"] = typeof(NortonCreepFormulation),
        ["NO_CREEP"] = typeof(NoCreepFormulation),
        ["STRAIN_HARDENING"] = typeof(StrainHardeningCreepFormulation),
        ["TIME_HARDENING"] = typeof(TimeHardeningCreepFormulation),
    };

    public override OneOf_LinearElasticMaterialBehaviorCreepFormulation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_LinearElasticMaterialBehaviorCreepFormulation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_LinearElasticMaterialBehaviorCreepFormulation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
