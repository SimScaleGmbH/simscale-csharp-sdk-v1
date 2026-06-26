using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StationaryTimeDependency : OneOf_HeatTransferTimeDependency, OneOf_EmbeddedBoundaryTimeDependency, OneOf_SimericsAnalysisTimeDependency, OneOf_CoupledConjugateHeatTransferTimeDependency, OneOf_ThermalMechanicalTimeDependency, OneOf_IncompressibleTimeDependency, OneOf_CompressibleTimeDependency, OneOf_ConvectiveHeatTransferTimeDependency, OneOf_TimeHarmonicMagneticsTimeDependency, OneOf_ConjugateHeatTransferTimeDependency
{
    /// <summary>Schema name: StationaryTimeDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATIONARY";

}
