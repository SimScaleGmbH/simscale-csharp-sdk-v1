using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The cyclic symmetry constraint enables to model only a sector of a 360° cyclic periodic structure and reduces the computation time and memory consumption considerably. The user defines the center and axis of the cyclic symmetry as well as the sector angle. The master and slave surfaces define the cyclic periodicity boundaries. Important remarks: All DOFs of the slave nodes will be constrained, adding an additional constraint on those nodes may lead to an overconstrained system.This is a linear constraint, so no large rotations or large deformations are allowed in the proximity of cyclic symmetry boundaries. Learn more.</summary>
public class CyclicSymmetryBC : OneOf_HeatTransferBoundaryConditions, OneOf_StaticAnalysisBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions, OneOf_DynamicAnalysisBoundaryConditions
{
    /// <summary>The cyclic symmetry constraint enables to model only a sector of a 360° cyclic periodic structure and reduces the com...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CYCLIC_SYMMETRY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Define if heat transfer should be allowed across the contact. If yes is chosen a perfectly bonded heat contact is ass...</summary>
    [JsonPropertyName("enableHeatTransfer")]
    public string? EnableHeatTransfer { get; set; }

    [JsonPropertyName("axisOrigin")]
    public DimensionalVector_Length? AxisOrigin { get; set; }

    [JsonPropertyName("axisDirection")]
    public DimensionalVector_Length? AxisDirection { get; set; }

    [JsonPropertyName("sectorAngle")]
    public Dimensional_Angle? SectorAngle { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

}
