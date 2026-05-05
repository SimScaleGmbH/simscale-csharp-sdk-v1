using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>A soft magnetic material can be easily magnetized and demagnetized. It can be a ferromagnetic material such as iron and non-ferromagnetic material such as copper or air.</summary>
public class SoftMagneticMaterial : OneOf_ElectromagneticMaterialMaterialBehavior
{
    /// <summary>A soft magnetic material can be easily magnetized and demagnetized. It can be a ferromagnetic material such as iron a...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SOFT_MAGNETIC";

}
