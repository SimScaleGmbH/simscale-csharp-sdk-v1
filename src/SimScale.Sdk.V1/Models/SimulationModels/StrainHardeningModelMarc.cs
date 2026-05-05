using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainHardeningModelMarc : OneOf_BilinearModelMarcHardeningModel
{
    /// <summary>Schema name: StrainHardeningModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN_HARDENING";

    [JsonPropertyName("ultimateTensileStress")]
    public Dimensional_Pressure? UltimateTensileStress { get; set; }

    [JsonPropertyName("ultimateTotalStrain")]
    public Dimensional_Dimensionless? UltimateTotalStrain { get; set; }

}
