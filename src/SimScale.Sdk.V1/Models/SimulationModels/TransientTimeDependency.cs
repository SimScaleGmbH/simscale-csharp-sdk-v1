using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TransientTimeDependency : OneOf_HeatTransferTimeDependency, OneOf_EmbeddedBoundaryTimeDependency, OneOf_SimericsAnalysisTimeDependency, OneOf_CoupledConjugateHeatTransferTimeDependency, OneOf_ThermalMechanicalTimeDependency, OneOf_IncompressibleTimeDependency, OneOf_CompressibleTimeDependency, OneOf_ConvectiveHeatTransferTimeDependency, OneOf_TimeHarmonicMagneticsTimeDependency, OneOf_ConjugateHeatTransferTimeDependency
{
    /// <summary>Schema name: TransientTimeDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TRANSIENT";

}
