using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Electrostatics : OneOf_ElectromagneticAnalysisModel
{
    /// <summary>Schema name: Electrostatics</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ELECTROSTATICS";

    /// <summary>Enabling allows the specification of the dielectric breakdown voltage for each material and the calculation of the sa...</summary>
    [JsonPropertyName("breakdown")]
    public bool? Breakdown { get; set; }

}
