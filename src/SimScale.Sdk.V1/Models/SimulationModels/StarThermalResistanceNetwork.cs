using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>A Thermal Resistance Network can be used to approximate the effect of heat sources and heat transfer from that source to the surrounding domain without resolving the source geometry. Select the top face of the body you want to assign. The models for Thermal resistance network are as follows:Star Network Resistance Model: defines a thermal resistance network consisting out of a top, a board, a board to interface and four side resistances. A power source is assigned to the body.Two resistor Model: defines a thermal resistance network consisting out of a top, a board and a board to interface resistance. A power source is assigned to the body. Learn more.</summary>
public class StarThermalResistanceNetwork : OneOf_AdvancedConceptsThermalResistanceNetworks
{
    /// <summary>A Thermal Resistance Network can be used to approximate the effect of heat sources and heat transfer from that source...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "STAR_NETWORK";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("resistanceTop")]
    public Dimensional_ContactResistance? ResistanceTop { get; set; }

    [JsonPropertyName("resistanceBottom")]
    public Dimensional_ContactResistance? ResistanceBottom { get; set; }

    [JsonPropertyName("resistanceSides")]
    public Dimensional_ContactResistance? ResistanceSides { get; set; }

    [JsonPropertyName("resistanceInterface")]
    public Dimensional_ContactResistance? ResistanceInterface { get; set; }

    [JsonPropertyName("networkPower")]
    public Dimensional_Power? NetworkPower { get; set; }

    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
