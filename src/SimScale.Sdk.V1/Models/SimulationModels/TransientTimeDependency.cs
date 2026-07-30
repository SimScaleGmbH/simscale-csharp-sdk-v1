using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TransientTimeDependency : OneOf_TimeHarmonicMagneticsTimeDependency, OneOf_SimericsAnalysisTimeDependency, OneOf_EmbeddedBoundaryTimeDependency, OneOf_IncompressibleTimeDependency, OneOf_CompressibleTimeDependency, OneOf_ConjugateHeatTransferTimeDependency, OneOf_ConvectiveHeatTransferTimeDependency, OneOf_ThermalMechanicalTimeDependency, OneOf_CoupledConjugateHeatTransferTimeDependency, OneOf_HeatTransferTimeDependency
{
    /// <summary>Schema name: TransientTimeDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRANSIENT";

}
