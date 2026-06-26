using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class CustomOrientation : OneOf_DirectionalMaterialStructureOrientation, OneOf_FixedCoeffMediumOrientation, OneOf_ConstAnIsoTransportOrientation, OneOf_DarcyForchheimerMediumOrientation
{
    /// <summary>Schema name: CustomOrientation</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CUSTOM";

    [JsonPropertyName("unitVector1")]
    public DimensionalVector_Length? UnitVector1 { get; set; }

    [JsonPropertyName("unitVector2")]
    public DimensionalVector_Length? UnitVector2 { get; set; }

}
