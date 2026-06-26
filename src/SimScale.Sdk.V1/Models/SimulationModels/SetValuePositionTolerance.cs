using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SetValuePositionTolerance : OneOf_MarcBondedContactConnectionPositionTolerance, OneOf_SlidingContactPositionTolerance, OneOf_BondedContactPositionTolerance, OneOf_MarcBondedAndTouchingContactConnectionPositionTolerance
{
    /// <summary>Schema name: SetValuePositionTolerance</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "SET_VALUE";

    [JsonPropertyName("tolerance")]
    public Dimensional_Length? Tolerance { get; set; }

}
