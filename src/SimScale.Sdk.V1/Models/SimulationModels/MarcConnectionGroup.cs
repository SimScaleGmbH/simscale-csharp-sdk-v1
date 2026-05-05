using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcConnectionGroup
{
    /// <summary>Schema name: MarcConnectionGroup</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONTACT";

    /// <summary>Define how tangential forces are handled when surfaces slide against each other.No Friction: Surfaces slide freely wi...</summary>
    [JsonPropertyName("friction")]
    public string? Friction { get; set; }

    /// <summary>Define how to search for and enforce contact constraints between contacting bodies:Double-sided: The solver checks fo...</summary>
    [JsonPropertyName("contactFormulation")]
    public string? ContactFormulation { get; set; }

    /// <summary>Define the criteria used to determine when two surfaces in contact should be allowed to pull apart.Automatic: The sol...</summary>
    [JsonPropertyName("separationControl")]
    public string? SeparationControl { get; set; }

    [JsonPropertyName("connections")]
    public List<OneOf_MarcConnectionGroupConnections>? Connections { get; set; }

}
