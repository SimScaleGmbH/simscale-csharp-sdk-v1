using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class NewtonContactNonLinearityResolution : OneOf_ConnectionSettingsV36ContactNonLinearityResolution
{
    /// <summary>Schema name: NewtonContactNonLinearityResolution</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "NEWTON";

}
