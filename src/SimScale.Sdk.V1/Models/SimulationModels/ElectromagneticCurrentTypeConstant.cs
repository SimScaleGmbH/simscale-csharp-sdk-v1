using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ElectromagneticCurrentTypeConstant : OneOf_CurrentExcitationCurrentType
{
    /// <summary>Schema name: ElectromagneticCurrentTypeConstant</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CURRENT_TYPE_CONSTANT";

    [JsonPropertyName("value")]
    public Dimensional_ElectricCurrent? Value { get; set; }

}
