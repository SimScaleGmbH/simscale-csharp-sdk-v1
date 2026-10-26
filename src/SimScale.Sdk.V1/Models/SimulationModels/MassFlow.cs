using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines the mass flow rate per each face of the assignment.</summary>
public class MassFlow : OneOf_FlowRateOutletVBCFlowRate, OneOf_FlowRateStableOutletVBCFlowRate, OneOf_FlowRateMeanOutletVBCFlowRate, OneOf_FlowRateInletVBCFlowRate, OneOf_FlowRateMeanInletVBCFlowRate
{
    /// <summary>Defines the mass flow rate per each face of the assignment. Schema name: MassFlow</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MASS";

    [JsonPropertyName("value")]
    public DimensionalFunction_MassFlowRate? Value { get; set; }

}
