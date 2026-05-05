using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class Contact : OneOf_ThermalMechanicalConnectionGroups, OneOf_StaticAnalysisConnectionGroups, OneOf_DynamicAnalysisConnectionGroups
{
    /// <summary>Schema name: Contact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    /// <summary>Allow node merging for bonded contacts where possible to increase contact accuracy and solution efficiency. For conta...</summary>
    [JsonPropertyName("nodeMergingBonded")]
    public bool? NodeMergingBonded { get; set; }

    [JsonPropertyName("connections")]
    public List<OneOf_ContactConnections>? Connections { get; set; }

}
