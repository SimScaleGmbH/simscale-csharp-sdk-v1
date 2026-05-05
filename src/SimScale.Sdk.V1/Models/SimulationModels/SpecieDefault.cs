using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specie: defines the molecular composition of the fluid material. Currently a single specie is available.</summary>
public class SpecieDefault
{
    /// <summary>Specie: defines the molecular composition of the fluid material. Currently a single specie is available. Schema name:...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIE";

    [JsonPropertyName("molarWeight")]
    public Dimensional_MolarMass? MolarWeight { get; set; }

}
