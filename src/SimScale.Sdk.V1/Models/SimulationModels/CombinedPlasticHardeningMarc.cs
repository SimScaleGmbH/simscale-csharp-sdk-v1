using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CombinedPlasticHardeningMarc : OneOf_MultilinearModelMarcHardeningRule, OneOf_BilinearModelMarcHardeningRule
{
    /// <summary>Schema name: CombinedPlasticHardeningMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COMBINED";

    /// <summary>This value (from 0 to 1) defines the weight of the kinematic component relative to the isotropic component for the co...</summary>
    [JsonPropertyName("kinematicFraction")]
    public double? KinematicFraction { get; set; }

}
