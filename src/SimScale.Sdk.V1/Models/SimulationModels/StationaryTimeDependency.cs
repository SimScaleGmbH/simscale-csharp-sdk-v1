using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StationaryTimeDependency : OneOf_ConjugateHeatTransferTimeDependency, OneOf_CoupledConjugateHeatTransferTimeDependency, OneOf_ConvectiveHeatTransferTimeDependency, OneOf_SimericsAnalysisTimeDependency, OneOf_CompressibleTimeDependency, OneOf_ThermalMechanicalTimeDependency, OneOf_IncompressibleTimeDependency, OneOf_HeatTransferTimeDependency, OneOf_EmbeddedBoundaryTimeDependency
{
    /// <summary>Schema name: StationaryTimeDependency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STATIONARY";

}
