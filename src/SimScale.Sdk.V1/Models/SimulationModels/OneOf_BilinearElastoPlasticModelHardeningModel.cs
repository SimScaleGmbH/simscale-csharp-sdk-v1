using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the hardening model for your problem. Important remarks: Choose Strain Hardening if the material response is a combination of linear elastic and plastic hardening behavior, where the material becomes progressively stiffer with increasing strain.Choose Perfect Plasticity if the material response is a combination of linear elastic and perfect plastic hardening behavior (constant stress for applied strain). Learn more</summary>
[JsonConverter(typeof(OneOf_BilinearElastoPlasticModelHardeningModelConverter))]
public interface OneOf_BilinearElastoPlasticModelHardeningModel { }

internal class OneOf_BilinearElastoPlasticModelHardeningModelConverter : JsonConverter<OneOf_BilinearElastoPlasticModelHardeningModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["STRAIN_HARDENING"] = typeof(StrainHardeningModel),
        ["PERFECT_PLASTICITY"] = typeof(PerfectPlasticityModel),
    };

    public override OneOf_BilinearElastoPlasticModelHardeningModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_BilinearElastoPlasticModelHardeningModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_BilinearElastoPlasticModelHardeningModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
