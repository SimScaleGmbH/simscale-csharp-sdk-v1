using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class AdvancedConcepts
{
    [JsonPropertyName("thermalContactResistance")]
    public List<OneOf_AdvancedConceptsThermalContactResistance>? ThermalContactResistance { get; set; }

    [JsonPropertyName("humiditySources")]
    public List<OneOf_AdvancedConceptsHumiditySources>? HumiditySources { get; set; }

    [JsonPropertyName("momentumSources")]
    public List<OneOf_AdvancedConceptsMomentumSources>? MomentumSources { get; set; }

    [JsonPropertyName("passiveScalarSources")]
    public List<OneOf_AdvancedConceptsPassiveScalarSources>? PassiveScalarSources { get; set; }

    [JsonPropertyName("porousMediums")]
    public List<OneOf_AdvancedConceptsPorousMediums>? PorousMediums { get; set; }

    [JsonPropertyName("powerSources")]
    public List<OneOf_AdvancedConceptsPowerSources>? PowerSources { get; set; }

    [JsonPropertyName("rotatingZones")]
    public List<OneOf_AdvancedConceptsRotatingZones>? RotatingZones { get; set; }

    [JsonPropertyName("solidBodyMotions")]
    public List<OneOf_AdvancedConceptsSolidBodyMotions>? SolidBodyMotions { get; set; }

    [JsonPropertyName("thermalResistanceNetworks")]
    public List<OneOf_AdvancedConceptsThermalResistanceNetworks>? ThermalResistanceNetworks { get; set; }

}
