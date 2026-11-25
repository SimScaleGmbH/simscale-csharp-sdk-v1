using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Connects parts through a virtual pin, so the pin itself is not modelled. Define one pin connector per pin.Assign the cylindrical hole faces of all parts the pin goes through:all faces on one common axis: no flat faces, no holes of another pineach face in one connector onlyBehavior: the parts turn about the pin axis but cannot tilt against each other. The virtual pin is rigid in bending and has no material or diameter. Set rotation and sliding under Kinematic behavior. Learn more</summary>
public class PinConnector : OneOf_DynamicAnalysisConnectors, OneOf_FrequencyAnalysisConnectors, OneOf_StaticAnalysisConnectors, OneOf_HarmonicAnalysisConnectors
{
    /// <summary>Connects parts through a virtual pin, so the pin itself is not modelled. Define one pin connector per pin.Assign the...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PIN_CONNECTOR";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Choose what the pin connects:Body to body: two or more parts are connected to each other. The pin moves with the part...</summary>
    [JsonPropertyName("interaction")]
    public string? Interaction { get; set; }

    [JsonPropertyName("kinematicBehavior")]
    public PinKinematicBehavior? KinematicBehavior { get; set; }

    [JsonPropertyName("advancedPinSettings")]
    public AdvancedConnectorSettings? AdvancedPinSettings { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
