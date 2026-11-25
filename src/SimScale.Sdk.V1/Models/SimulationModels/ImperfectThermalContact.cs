using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ImperfectThermalContact : OneOf_MarcBondedAndTouchingContactConnectionThermalContact, OneOf_MarcBondedContactConnectionThermalContact, OneOf_MarcTouchingContactConnectionThermalContact
{
    /// <summary>Schema name: ImperfectThermalContact</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "IMPERFECT";

    [JsonPropertyName("marcContactConductance")]
    public Dimensional_ThermalTransmittance? MarcContactConductance { get; set; }

}
