using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CenterFrequency : OneOf_ModalBaseControlEigenfrequencyScope, OneOf_SolidSimulationControlEigenfrequencyScope
{
    /// <summary>Schema name: CenterFrequency</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CENTER";

    [JsonPropertyName("centerFrequency")]
    public Dimensional_Frequency? CenterFrequencyValue { get; set; }

    /// <summary>Define the maximum number of eigenfrequencies/eigenmodes, that should be calculated.</summary>
    [JsonPropertyName("numberOfModes")]
    public int? NumberOfModes { get; set; }

}
