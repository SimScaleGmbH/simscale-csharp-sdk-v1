using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class CometsVisualizationStyle : OneOfVisualizationStyle
{
    /// <summary>The representation to use for particle traces.</summary>
    [JsonPropertyName("representation")]
    public string Representation { get; set; } = "COMETS";

    /// <summary>This value specifies how many pulses there should be in the model.</summary>
    [JsonPropertyName("numPulses")]
    public int NumPulses { get; set; } = 15;

    /// <summary>The length of the tail of the comets. It is specified in time and is a fraction of the global total time range for al...</summary>
    [JsonPropertyName("relativeCometLength")]
    public double RelativeCometLength { get; set; } = 1e-05d;

}
