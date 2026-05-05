using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class YAxis : OneOf_ConstCrossPlaneOrthotropicTransportOrientation
{
    /// <summary>Schema name: YAxis</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "YAXIS";

}
