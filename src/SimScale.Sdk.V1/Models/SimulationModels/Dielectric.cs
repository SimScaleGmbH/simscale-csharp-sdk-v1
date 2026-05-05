using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Dielectric materials do not conduct electric field.</summary>
public class Dielectric : OneOf_SolidCompressibleMaterialElectricConductivityType
{
    /// <summary>Dielectric materials do not conduct electric field. Schema name: Dielectric</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "DIELECTRIC";

}
