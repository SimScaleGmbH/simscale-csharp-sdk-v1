using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FlowDomainBoundaries
{
    [JsonPropertyName("XMIN")]
    public OneOf_FlowDomainBoundariesXMIN? Xmin { get; set; }

    [JsonPropertyName("XMAX")]
    public OneOf_FlowDomainBoundariesXMAX? Xmax { get; set; }

    [JsonPropertyName("YMIN")]
    public OneOf_FlowDomainBoundariesYMIN? Ymin { get; set; }

    [JsonPropertyName("YMAX")]
    public OneOf_FlowDomainBoundariesYMAX? Ymax { get; set; }

    [JsonPropertyName("ZMIN")]
    public OneOf_FlowDomainBoundariesZMIN? Zmin { get; set; }

    [JsonPropertyName("ZMAX")]
    public OneOf_FlowDomainBoundariesZMAX? Zmax { get; set; }

}
