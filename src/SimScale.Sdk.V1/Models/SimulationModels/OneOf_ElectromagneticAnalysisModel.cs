using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>ElectrostaticsUse for problems where electric fields and charges are stationary, and no time-varying electromagnetic fields are present.MagnetostaticsUse for problems where magnetic fields are constant over time and thus no eddy currents are present. Time-Harmonic MagneticsUse for problems where magnetic fields and electric currents are sinusoidally varying. Time-Transient MagneticsUse for problems where magnetic fields and electric currents are time-dependent.Learn more</summary>
[JsonConverter(typeof(OneOf_ElectromagneticAnalysisModelConverter))]
public interface OneOf_ElectromagneticAnalysisModel { }

internal class OneOf_ElectromagneticAnalysisModelConverter : JsonConverter<OneOf_ElectromagneticAnalysisModel>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["ELECTROSTATICS"] = typeof(Electrostatics),
        ["TIME_HARMONIC_ELECTRICS"] = typeof(TimeHarmonicElectrics),
        ["MAGNETOSTATICS"] = typeof(Magnetostatics),
        ["TIME_HARMONIC_MAGNETICS"] = typeof(TimeHarmonicMagnetics),
        ["TIME_TRANSIENT_MAGNETICS"] = typeof(TimeTransientMagnetics),
    };

    public override OneOf_ElectromagneticAnalysisModel? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ElectromagneticAnalysisModel?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ElectromagneticAnalysisModel value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
