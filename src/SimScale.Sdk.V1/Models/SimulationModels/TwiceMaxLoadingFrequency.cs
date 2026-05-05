using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TwiceMaxLoadingFrequency : OneOf_ModalBaseControlEigenfrequencyScope
{
    /// <summary>Schema name: TwiceMaxLoadingFrequency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TWICE_MAX_LOADING_FREQUENCY";

}
