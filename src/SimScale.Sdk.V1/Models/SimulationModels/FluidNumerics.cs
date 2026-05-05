using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidNumerics
{
    [JsonPropertyName("relaxationType")]
    public string? RelaxationType { get; set; }

    [JsonPropertyName("relaxationFactor")]
    public RelaxationFactor? RelaxationFactor { get; set; }

    [JsonPropertyName("diagonalRelaxationFactor")]
    public RelaxationFactor? DiagonalRelaxationFactor { get; set; }

    /// <summary>Enabling this option makes the viscous work terms included everywhere in the domain.</summary>
    [JsonPropertyName("viscousWorkIncluded")]
    public bool? ViscousWorkIncluded { get; set; }

    [JsonPropertyName("radiationResolution")]
    public string? RadiationResolution { get; set; }

    [JsonPropertyName("momentumPredictor")]
    public bool? MomentumPredictor { get; set; }

    [JsonPropertyName("transonic")]
    public bool? Transonic { get; set; }

    [JsonPropertyName("numOuterCorrectors")]
    public int? NumOuterCorrectors { get; set; }

    [JsonPropertyName("numCorrectors")]
    public int? NumCorrectors { get; set; }

    /// <summary>The pressure equation is repeatedly solved based on the value of non-orthogonal correctors in the PISO/SIMPLE/PIMPLE...</summary>
    [JsonPropertyName("numNonOrthogonalCorrectors")]
    public int? NumNonOrthogonalCorrectors { get; set; }

    [JsonPropertyName("smoothingParameter")]
    public double? SmoothingParameter { get; set; }

    [JsonPropertyName("dampingCoefficient")]
    public double? DampingCoefficient { get; set; }

    [JsonPropertyName("numAlphaSpreadIterations")]
    public int? NumAlphaSpreadIterations { get; set; }

    [JsonPropertyName("numAlphaSweepIterations")]
    public int? NumAlphaSweepIterations { get; set; }

    [JsonPropertyName("evaluateTurbulenceOnlyOnFinalIteration")]
    public bool? EvaluateTurbulenceOnlyOnFinalIteration { get; set; }

    /// <summary>Enter the cell where you want to define reference pressure in the PISO/SIMPLE/PIMPLE algorithm.</summary>
    [JsonPropertyName("pressureReferenceCell")]
    public int? PressureReferenceCell { get; set; }

    [JsonPropertyName("pressureReferenceValue")]
    public Dimensional_Pressure? PressureReferenceValue { get; set; }

    [JsonPropertyName("velocityLimit")]
    public Dimensional_Speed? VelocityLimit { get; set; }

    [JsonPropertyName("maxVoltageInitialIterations")]
    public double? MaxVoltageInitialIterations { get; set; }

    [JsonPropertyName("voltageInitialTolerance")]
    public double? VoltageInitialTolerance { get; set; }

    [JsonPropertyName("residualControls")]
    public ResidualControls? ResidualControls { get; set; }

    [JsonPropertyName("solvers")]
    public FluidSolvers? Solvers { get; set; }

    [JsonPropertyName("schemes")]
    public Schemes? Schemes { get; set; }

    [JsonPropertyName("stabilization")]
    public Stabilization? Stabilization { get; set; }

}
