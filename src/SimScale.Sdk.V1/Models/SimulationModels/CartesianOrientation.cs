using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CartesianOrientation : OneOf_FixedCoeffMediumOrientation, OneOf_DarcyForchheimerMediumOrientation, OneOf_DirectionalMaterialStructureOrientation, OneOf_ConstAnIsoTransportOrientation
{
    /// <summary>Schema name: CartesianOrientation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN";

}
