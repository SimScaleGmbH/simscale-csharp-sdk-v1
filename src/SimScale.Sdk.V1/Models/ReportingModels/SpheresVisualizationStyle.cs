using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class SpheresVisualizationStyle : OneOfVisualizationStyle
{
    /// <summary>The representation to use for particle traces.</summary>
    [JsonPropertyName("representation")]
    public string Representation { get; set; } = "SPHERES";

    /// <summary>This value specifies how many pulses there should be in the model.</summary>
    [JsonPropertyName("numPulses")]
    public int NumPulses { get; set; } = 15;

}
