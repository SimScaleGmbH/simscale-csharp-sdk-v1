using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CartesianOrientation : OneOf_DarcyForchheimerMediumOrientation, OneOf_FixedCoeffMediumOrientation, OneOf_ConstAnIsoTransportOrientation, OneOf_DirectionalMaterialStructureOrientation
{
    /// <summary>Schema name: CartesianOrientation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CARTESIAN";

}
