using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class OffPositionTolerance : OneOf_MarcBondedContactConnectionPositionTolerance, OneOf_BondedContactPositionTolerance, OneOf_MarcBondedAndTouchingContactConnectionPositionTolerance, OneOf_SlidingContactPositionTolerance
{
    /// <summary>Schema name: OffPositionTolerance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "OFF";

}
