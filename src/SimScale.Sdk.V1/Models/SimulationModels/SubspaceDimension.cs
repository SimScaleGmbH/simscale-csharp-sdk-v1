using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubspaceDimension : OneOf_LanczosSubspaceSettings, OneOf_BatheWilsonSubspaceSettings, OneOf_IRAMSorensenSubspaceSettings
{
    /// <summary>Schema name: SubspaceDimension</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUBSPACE_DIMENSION";

    /// <summary>Specify the subspace dimension. It is recommended to check the error log to get a hint for how to select it. It must...</summary>
    [JsonPropertyName("subspaceDimension")]
    public int? SubspaceDimensionValue { get; set; }

}
