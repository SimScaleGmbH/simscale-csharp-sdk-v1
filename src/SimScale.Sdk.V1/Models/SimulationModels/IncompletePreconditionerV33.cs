using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IncompletePreconditionerV33 : OneOf_AdvancedPETSCSettingsPreconditioner
{
    /// <summary>Schema name: IncompletePreconditionerV33</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INCOMPLETE_LDLT_V33";

    /// <summary>Set the level of completeness for the incomplete Cholesky decomposition. The larger this value is, the better the pre...</summary>
    [JsonPropertyName("matrixCompleteness")]
    public int? MatrixCompleteness { get; set; }

    /// <summary>Set the growth rate of the filling for the incomplete decomposition matrix. If this parameter is set to 1.0 PETSc est...</summary>
    [JsonPropertyName("preconditionerMatrixGrowth")]
    public double? PreconditionerMatrixGrowth { get; set; }

}
