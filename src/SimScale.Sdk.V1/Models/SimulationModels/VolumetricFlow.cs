using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines the volumetric flow rate per each face of the assignment.</summary>
public class VolumetricFlow : OneOf_FlowRateOutletVBCFlowRate, OneOf_FlowRateStableOutletVBCFlowRate, OneOf_FlowRateMeanOutletVBCFlowRate, OneOf_FlowRateInletVBCFlowRate, OneOf_FlowRateMeanInletVBCFlowRate
{
    /// <summary>Defines the volumetric flow rate per each face of the assignment. Schema name: VolumetricFlow</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUMETRIC";

    [JsonPropertyName("value")]
    public DimensionalFunction_VolumetricFlowRate? Value { get; set; }

}
