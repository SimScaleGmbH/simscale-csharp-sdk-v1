using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MUMPSPreconditoner : OneOf_AdvancedPETSCSettingsPreconditioner
{
    /// <summary>Schema name: MUMPSPreconditoner</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MUMPS_LDLT";

    /// <summary>Set the reactualisation intervall for the preconditioner matrix P. If this value is set to 30 the preconditioner is r...</summary>
    [JsonPropertyName("actualisationRate")]
    public int? ActualisationRate { get; set; }

    /// <summary>Define how much additional memory should be reserved for the pivoting operations. If MUMPS estimates that the necessa...</summary>
    [JsonPropertyName("memoryPercentageForPivoting")]
    public double? MemoryPercentageForPivoting { get; set; }

}
