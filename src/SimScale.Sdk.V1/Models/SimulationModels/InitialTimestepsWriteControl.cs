using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define how frequently intermediate results should be saved. With the selection of initial time steps only the user defined time steps are stored in the result and by selecting all computed time steps also intermediate results that were created by the automatic time stepping are saved. With the selection of write interval a specific write frequency can be chosen which reduces the result size. Finally using user defined time steps there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the time step length definition.</summary>
public class InitialTimestepsWriteControl : OneOf_SolidSimulationControlWriteControlDefinition
{
    /// <summary>Define how frequently intermediate results should be saved. With the selection of initial time steps only the user de...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INITIAL";

}
