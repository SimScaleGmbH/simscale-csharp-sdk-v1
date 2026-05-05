using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose Perfectly plastic if the material maintains a constant stress level after yielding, or Strain hardening if the material's strength increases as it undergoes further plastic deformation.</summary>
[JsonConverter(typeof(OneOf_BilinearModelMarcHardeningModelConverter))]
public interface OneOf_BilinearModelMarcHardeningModel { }

internal class OneOf_BilinearModelMarcHardeningModelConverter : JsonConverter<OneOf_BilinearModelMarcHardeningModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PERFECT_PLASTICITY"] = typeof(PerfectPlasticityModelMarc),
        ["STRAIN_HARDENING"] = typeof(StrainHardeningModelMarc),
    };

    public override OneOf_BilinearModelMarcHardeningModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_BilinearModelMarcHardeningModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_BilinearModelMarcHardeningModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
