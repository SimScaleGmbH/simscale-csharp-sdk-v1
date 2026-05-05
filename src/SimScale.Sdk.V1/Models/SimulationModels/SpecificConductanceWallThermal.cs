using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SpecificConductanceWallThermal : OneOf_DerivedHeatFluxWallThermal
{
    /// <summary>Schema name: SpecificConductanceWallThermal</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SPECIFIC_CONDUCTANCE";

    [JsonPropertyName("contactConductance")]
    public Dimensional_ThermalTransmittance? ContactConductance { get; set; }

}
