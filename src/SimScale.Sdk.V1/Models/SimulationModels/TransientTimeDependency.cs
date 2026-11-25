using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TransientTimeDependency : OneOf_SimericsAnalysisTimeDependency, OneOf_IncompressibleTimeDependency, OneOf_CoupledConjugateHeatTransferTimeDependency, OneOf_HeatTransferTimeDependency, OneOf_TimeHarmonicMagneticsTimeDependency, OneOf_ThermalMechanicalTimeDependency, OneOf_ConjugateHeatTransferTimeDependency, OneOf_CompressibleTimeDependency, OneOf_ConvectiveHeatTransferTimeDependency, OneOf_EmbeddedBoundaryTimeDependency
{
    /// <summary>Schema name: TransientTimeDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRANSIENT";

}
