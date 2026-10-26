using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class VoceChabocheModelMarc : OneOf_PlasticityMarcPlasticityModel
{
    /// <summary>Schema name: VoceChabocheModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOCE_CHABOCHE";

    [JsonPropertyName("initialYieldStress")]
    public Dimensional_Pressure? InitialYieldStress { get; set; }

    [JsonPropertyName("hardeningRule")]
    public OneOf_VoceChabocheModelMarcHardeningRule? HardeningRule { get; set; }

}
