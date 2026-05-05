using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(AnalysisConverter))]
public interface Analysis { }

internal class AnalysisConverter : JsonConverter<Analysis>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["STATIC_ANALYSIS"] = typeof(StaticAnalysis),
        ["DYNAMIC_ANALYSIS"] = typeof(DynamicAnalysis),
        ["HEAT_TRANSFER"] = typeof(HeatTransfer),
        ["THERMAL_MECHANICAL"] = typeof(ThermalMechanical),
        ["INCOMPRESSIBLE"] = typeof(Incompressible),
        ["INCOMPRESSIBLE_PACEFISH"] = typeof(IncompressiblePacefish),
        ["SIMERICS_ANALYSIS"] = typeof(SimericsAnalysis),
        ["WIND_COMFORT"] = typeof(WindComfort),
        ["COMPRESSIBLE"] = typeof(Compressible),
        ["CONVECTIVE_HEAT_TRANSFER"] = typeof(ConvectiveHeatTransfer),
        ["COUPLED_CONJUGATE_HEAT_TRANSFER"] = typeof(CoupledConjugateHeatTransfer),
        ["EMBEDDED_BOUNDARY"] = typeof(EmbeddedBoundary),
        ["MULTIPHASE"] = typeof(Multiphase),
        ["CONJUGATE_HEAT_TRANSFER"] = typeof(ConjugateHeatTransfer),
        ["HARMONIC_ANALYSIS"] = typeof(HarmonicAnalysis),
        ["FREQUENCY_ANALYSIS"] = typeof(FrequencyAnalysis),
        ["ELECTROMAGNETIC_ANALYSIS"] = typeof(ElectromagneticAnalysis),
        ["MARC_ANALYSIS"] = typeof(MarcAnalysis),
    };

    public override Analysis? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((Analysis?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, Analysis value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
