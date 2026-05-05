using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticCurrentTypeTable : OneOf_CurrentExcitationCurrentType
{
    /// <summary>Schema name: ElectromagneticCurrentTypeTable</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_TYPE_TABLE";

    [JsonPropertyName("values")]
    public DimensionalFunction_ElectricCurrent? Values { get; set; }

}
