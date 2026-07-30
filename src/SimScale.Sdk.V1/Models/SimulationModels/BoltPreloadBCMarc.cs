using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Bolt preload boundary condition allows you to model pre-stressed fasteners in structural assemblies by assigning clamping conditions directly to solid volumes representing the bolt shanks. For each assigned volume, an individual bolt preload with the defined value is created and evaluated independently.Note:Ramping phase: During the first active load step, the specified force or displacement linearly ramps up from zero to your target value.Locked phase: From the second active load step onwards, the solver automatically imposes a zero axial shortening condition, locking the bolt at its current stretched length so it properly resists external loads.Open condition: If a bolt volume has no active preload boundary condition during a given load step, it enters an "open" state where it cannot resist external forces. To ensure an already tightened bolt resists external loads in subsequent stages without adding more preload, you can also specify a Length control mode with an Axial shortening of 0 m for those steps.Multiple conditions: You can apply multiple bolt preload boundary conditions to the same volume (e.g., to change tightening states across stages), provided that their active load steps do not overlap.Example: The below diagram explains the states of the bolt preload for a sample setup with four load steps, where the bolt preload is active on steps 2 and 3 and inactive on load steps 1 and 4:</summary>
public class BoltPreloadBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>Bolt preload boundary condition allows you to model pre-stressed fasteners in structural assemblies by assigning clam...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOLT_PRELOAD";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Control mode determines whether the bolt pre-tensioning behavior is governed by a target force or a specific phys...</summary>
    [JsonPropertyName("controlMode")]
    public string? ControlMode { get; set; }

    [JsonPropertyName("compressionForce")]
    public Dimensional_Force? CompressionForce { get; set; }

    [JsonPropertyName("axialShortening")]
    public Dimensional_Length? AxialShortening { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
