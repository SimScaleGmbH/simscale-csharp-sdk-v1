using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Bearing load spreads a force over a sector of one or more cylindrical faces, the way a pin loads a bore or a housing loads a journal. The sector is centred on the direction of the force, and the nodal forces always sum to the resultant.All assigned faces must be cylindrical and share the same cylinder axis. Only the radial part of the force is applied: a component along the cylinder axis is ignored. Use a separate force for axial thrust.</summary>
public class BearingLoadBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>Bearing load spreads a force over a sector of one or more cylindrical faces, the way a pin loads a bore or a housing...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BEARING_LOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("loadDistribution")]
    public BearingLoadDistributionMarc? LoadDistribution { get; set; }

    /// <summary>The coordinate system in which the vector components are expressed. Select from the available local coordinate system...</summary>
    [JsonPropertyName("coordinateSystem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CoordinateSystem { get; set; }

    [JsonPropertyName("force")]
    public DimensionalVectorFunctionWithLCS_Force? Force { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("automaticLoadRamping")]
    public AutomaticLoadRampingMarc? AutomaticLoadRamping { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
