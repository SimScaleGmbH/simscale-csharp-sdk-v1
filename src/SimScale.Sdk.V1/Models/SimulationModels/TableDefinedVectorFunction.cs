using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TableDefinedVectorFunction : OneOf_DimensionalVectorFunction_SpeedValue, OneOf_DimensionalVectorFunction_LengthValue, OneOf_DimensionalVectorFunction_PressureValue, OneOf_DimensionalVectorFunction_ForceValue, OneOf_DimensionalVectorFunction_TorqueValue, OneOf_DimensionalVectorFunction_VolumeForceValue, OneOf_DimensionalVectorFunction_AccelerationValue
{
    /// <summary>Schema name: TableDefinedVectorFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TABLE_DEFINED";

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The ID of the imported table.</summary>
    [JsonPropertyName("tableId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid TableId { get; set; }

    /// <summary>Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set...</summary>
    [JsonPropertyName("resultIndex")]
    public List<int>? ResultIndex { get; set; }

    [JsonPropertyName("independentVariables")]
    public List<TableFunctionParameter>? IndependentVariables { get; set; }

    /// <summary>Values in each row are separated by this character. Also known as a delimiter.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("outOfBounds")]
    public string? OutOfBounds { get; set; }

}
