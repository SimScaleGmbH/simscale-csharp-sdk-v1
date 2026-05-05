using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IncompressiblePacefish : Analysis
{
    /// <summary>Schema name: IncompressiblePacefish</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INCOMPRESSIBLE_PACEFISH";

    [JsonPropertyName("boundingBoxUuid")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid BoundingBoxUuid { get; set; }

    /// <summary>Choose between RANS, LES, or DES turbulence models. Learn more.</summary>
    [JsonPropertyName("turbulenceModel")]
    public string? TurbulenceModel { get; set; }

    [JsonPropertyName("material")]
    public IncompressibleMaterial? Material { get; set; }

    [JsonPropertyName("flowDomainBoundaries")]
    public FlowDomainBoundaries? FlowDomainBoundaries { get; set; }

    [JsonPropertyName("simulationControl")]
    public FluidSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("advancedModelling")]
    public AdvancedModelling? AdvancedModelling { get; set; }

    [JsonPropertyName("resultControl")]
    public FluidResultControls? ResultControl { get; set; }

    [JsonPropertyName("meshSettingsNew")]
    public OneOf_IncompressiblePacefishMeshSettingsNew? MeshSettingsNew { get; set; }

}
