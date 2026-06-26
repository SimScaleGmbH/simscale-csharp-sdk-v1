using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Connect multiple bodies via a virtual pin Usage: Define a separate pin connector item for each virtual pinAssign only cylindrical surfacesBehavior:Option to connect bodies to bodies or bodies to the ground via virtual pinsBodies freely rotate relative to one another about the virtual pin axisUsers have full control over axial translation and rotation of the connection with the ability to define torsional and axial spring stiffness</summary>
public class PinConnector : OneOf_HarmonicAnalysisConnectors, OneOf_StaticAnalysisConnectors, OneOf_FrequencyAnalysisConnectors, OneOf_DynamicAnalysisConnectors
{
    /// <summary>Connect multiple bodies via a virtual pin Usage: Define a separate pin connector item for each virtual pinAssign only...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "PIN_CONNECTOR";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Select an interaction optionBody to body - Two or more bodies may be connected to each other via a single virtual pin...</summary>
    [JsonPropertyName("interaction")]
    public string? Interaction { get; set; }

    [JsonPropertyName("kinematicBehavior")]
    public PinKinematicBehavior? KinematicBehavior { get; set; }

    [JsonPropertyName("advancedPinSettings")]
    public AdvancedConnectorSettings? AdvancedPinSettings { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
