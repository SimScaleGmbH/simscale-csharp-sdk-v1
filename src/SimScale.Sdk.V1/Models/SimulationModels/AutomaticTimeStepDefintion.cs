using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticTimeStepDefintion : OneOf_MarcSimulationControlTimestepDefinition
{
    /// <summary>Schema name: AutomaticTimeStepDefintion</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

    [JsonPropertyName("endTime")]
    public Dimensional_Time? EndTime { get; set; }

    [JsonPropertyName("initialTimeStep")]
    public Dimensional_Time? InitialTimeStep { get; set; }

    [JsonPropertyName("minimumTimeStep")]
    public Dimensional_Time? MinimumTimeStep { get; set; }

    [JsonPropertyName("maximumTimeStep")]
    public Dimensional_Time? MaximumTimeStep { get; set; }

    /// <summary>Enable or disable user-defined criteria to control automatic time stepping adjustments during simulation.</summary>
    [JsonPropertyName("physicalCriteria")]
    public bool? PhysicalCriteria { get; set; }

    /// <summary>Enable to limit time step based on displacement increment.</summary>
    [JsonPropertyName("displacementCriteria")]
    public bool? DisplacementCriteria { get; set; }

    [JsonPropertyName("displacementIncrement")]
    public Dimensional_Length? DisplacementIncrement { get; set; }

    /// <summary>Enable to limit time step based on total strain increment.</summary>
    [JsonPropertyName("totalStrainCriteria")]
    public bool? TotalStrainCriteria { get; set; }

    [JsonPropertyName("totalStrainIncrement")]
    public Dimensional_Dimensionless? TotalStrainIncrement { get; set; }

    /// <summary>Enable to limit time step based on plastic strain increment.</summary>
    [JsonPropertyName("plasticStrainCriteria")]
    public bool? PlasticStrainCriteria { get; set; }

    [JsonPropertyName("plasticStrainIncrement")]
    public Dimensional_Dimensionless? PlasticStrainIncrement { get; set; }

    /// <summary>Enable to limit time step based on stress increment.</summary>
    [JsonPropertyName("stressCriteria")]
    public bool? StressCriteria { get; set; }

    [JsonPropertyName("stressIncrement")]
    public Dimensional_Pressure? StressIncrement { get; set; }

}
