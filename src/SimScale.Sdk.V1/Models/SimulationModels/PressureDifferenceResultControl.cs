using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PressureDifferenceResultControl : OneOf_FluidResultControlsSurfaceData
{
    /// <summary>Schema name: PressureDifferenceResultControl</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PRESSURE_DIFFERENCE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Ensure a non-negative pressure difference result. Useful for many applications in which the pressure difference is as...</summary>
    [JsonPropertyName("absoluteValueOfPressureDifference")]
    public bool? AbsoluteValueOfPressureDifference { get; set; }

    /// <summary>The total pressure is the sum of the static pressure and the dynamic pressure.</summary>
    [JsonPropertyName("inletFacePressureDifferenceType")]
    public string? InletFacePressureDifferenceType { get; set; }

    [JsonPropertyName("inletFaceTopologicalReference")]
    public TopologicalReference? InletFaceTopologicalReference { get; set; }

    /// <summary>The total pressure is the sum of the static pressure and the dynamic pressure.</summary>
    [JsonPropertyName("outletFacePressureDifferenceType")]
    public string? OutletFacePressureDifferenceType { get; set; }

    [JsonPropertyName("outletFaceTopologicalReference")]
    public TopologicalReference? OutletFaceTopologicalReference { get; set; }

}
