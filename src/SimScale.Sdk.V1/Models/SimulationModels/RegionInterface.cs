using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class RegionInterface
{
    /// <summary>Schema name: RegionInterface</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "REGION_INTERFACE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("interfaceThermal")]
    public OneOf_RegionInterfaceInterfaceThermal? InterfaceThermal { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

    [JsonPropertyName("isPartial")]
    public bool? IsPartial { get; set; }

    [JsonPropertyName("customModified")]
    public bool? CustomModified { get; set; }

}
