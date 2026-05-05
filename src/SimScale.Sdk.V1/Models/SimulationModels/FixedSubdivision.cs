using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FixedSubdivision
{
    /// <summary>Define the number of equal subdivisions of a time step in case of an adaptation event.</summary>
    [JsonPropertyName("numSubdivisions")]
    public int? NumSubdivisions { get; set; }

    /// <summary>Define maximum depth of the timestep subdivisions. If this value is exceeded the computation will stop. Example: If t...</summary>
    [JsonPropertyName("maxSubdivisionDepth")]
    public int? MaxSubdivisionDepth { get; set; }

}
