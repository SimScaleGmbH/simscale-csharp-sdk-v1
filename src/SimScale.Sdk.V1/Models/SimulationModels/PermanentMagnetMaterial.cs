using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>A permanent magnet retains a significant portion of its magnetization indefinitely, even without an external magnetic field.</summary>
public class PermanentMagnetMaterial : OneOf_ElectromagneticMaterialMaterialBehavior
{
    /// <summary>A permanent magnet retains a significant portion of its magnetization indefinitely, even without an external magnetic...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PERMANENT_MAGNET";

    [JsonPropertyName("remanence")]
    public Dimensional_MagneticFluxDensity? Remanence { get; set; }

    [JsonPropertyName("magnetizationDirectionType")]
    public OneOf_PermanentMagnetMaterialMagnetizationDirectionType? MagnetizationDirectionType { get; set; }

}
