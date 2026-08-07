using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AutomaticSubspaceSettings : OneOf_LanczosSubspaceSettings, OneOf_BatheWilsonSubspaceSettings, OneOf_IRAMSorensenSubspaceSettings
{
    /// <summary>Schema name: AutomaticSubspaceSettings</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "AUTOMATIC";

}
