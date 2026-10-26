using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SubspaceCoefficient : OneOf_IRAMSorensenSubspaceSettings, OneOf_LanczosSubspaceSettings, OneOf_BatheWilsonSubspaceSettings
{
    /// <summary>Schema name: SubspaceCoefficient</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SUBSPACE_COEFFICIENT";

    /// <summary>Choose a coefficient (css) with which the subspace dimension (dss) is calculated, depending on the number of computed...</summary>
    [JsonPropertyName("subspaceCoefficient")]
    public int? SubspaceCoefficientValue { get; set; }

}
