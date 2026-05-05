using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ModalBaseControl
{
    [JsonPropertyName("eigenfrequencyScope")]
    public OneOf_ModalBaseControlEigenfrequencyScope? EigenfrequencyScope { get; set; }

}
