using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ContactInterfaceMaterialInterfaceThermal : OneOf_RegionInterfaceInterfaceThermal
{
    /// <summary>Schema name: ContactInterfaceMaterialInterfaceThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT_INTERFACE_MATERIAL";

    [JsonPropertyName("conductivityThicknessPairs")]
    public List<ConductivityThicknessPair>? ConductivityThicknessPairs { get; set; }

}
