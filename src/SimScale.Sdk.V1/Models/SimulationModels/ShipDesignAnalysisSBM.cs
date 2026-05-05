using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ShipDesignAnalysisSBM : OneOf_AdvancedConceptsSolidBodyMotions
{
    /// <summary>Schema name: ShipDesignAnalysisSBM</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SHIP_DESIGN_ANALYSIS";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("centerOfGravity")]
    public DimensionalVector_Length? CenterOfGravity { get; set; }

    [JsonPropertyName("modelScaleRatio")]
    public double? ModelScaleRatio { get; set; }

    [JsonPropertyName("maxRollAmplitude")]
    public Dimensional_Angle? MaxRollAmplitude { get; set; }

    [JsonPropertyName("minRollAmplitude")]
    public Dimensional_Angle? MinRollAmplitude { get; set; }

    [JsonPropertyName("heaveAmplitude")]
    public Dimensional_Length? HeaveAmplitude { get; set; }

    [JsonPropertyName("swayAmplitude")]
    public Dimensional_Length? SwayAmplitude { get; set; }

    [JsonPropertyName("dampingCoefficient")]
    public double? DampingCoefficient { get; set; }

    [JsonPropertyName("timePeriodForLiquid")]
    public Dimensional_Time? TimePeriodForLiquid { get; set; }

    [JsonPropertyName("naturalPeriodOfShip")]
    public Dimensional_Time? NaturalPeriodOfShip { get; set; }

    [JsonPropertyName("referenceTimeStep")]
    public Dimensional_Time? ReferenceTimeStep { get; set; }

    [JsonPropertyName("increaseInLiquidPerTimeStep")]
    public double? IncreaseInLiquidPerTimeStep { get; set; }

}
