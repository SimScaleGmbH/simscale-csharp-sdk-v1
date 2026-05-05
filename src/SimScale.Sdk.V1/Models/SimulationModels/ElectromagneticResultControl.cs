using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticResultControl
{
    /// <summary>Calculate the inductance matrix of the coils.</summary>
    [JsonPropertyName("calculateInductances")]
    public bool? CalculateInductances { get; set; }

    /// <summary>Calculate the capacitance matrix of the conductive bodies.Note that the field solution will be modified.</summary>
    [JsonPropertyName("calculateCapacitances")]
    public bool? CalculateCapacitances { get; set; }

    [JsonPropertyName("forcesAndTorques")]
    public List<ForceAndTorque>? ForcesAndTorques { get; set; }

    [JsonPropertyName("probePoints")]
    public List<ElectromagneticResultControlProbePoint>? ProbePoints { get; set; }

    [JsonPropertyName("resistanceSets")]
    public List<ElectromagneticResistanceSet>? ResistanceSets { get; set; }

}
