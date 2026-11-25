using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class StrainHardeningModelMarc : OneOf_BilinearModelMarcHardeningModel
{
    /// <summary>Schema name: StrainHardeningModelMarc</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STRAIN_HARDENING";

    [JsonPropertyName("ultimateTensileStressFunction")]
    public DimensionalFunction_Pressure? UltimateTensileStressFunction { get; set; }

    [JsonPropertyName("ultimateTotalStrainFunction")]
    public DimensionalFunction_Dimensionless? UltimateTotalStrainFunction { get; set; }

}
