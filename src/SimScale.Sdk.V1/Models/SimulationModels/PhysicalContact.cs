using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PhysicalContact : OneOf_ThermalMechanicalConnectionGroups, OneOf_StaticAnalysisConnectionGroups, OneOf_DynamicAnalysisConnectionGroups
{
    /// <summary>Schema name: PhysicalContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PHYSICAL_CONTACT_V36";

    [JsonPropertyName("settings")]
    public ConnectionSettingsV36? Settings { get; set; }

    [JsonPropertyName("connections")]
    public List<OneOf_PhysicalContactConnections>? Connections { get; set; }

}
