using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Connect multiple bodies via a virtual bolt Usage: Define a separate bolt connector item for each virtual boltAssign entities must be coaxialBehavior:Bolt connectors mimic physical bolts using beam formulations. Relative translations and rotations of the connected entities are computed based on the defined bolt mechanical propertiesAbility to apply preload</summary>
public class BoltConnector : OneOf_HarmonicAnalysisConnectors, OneOf_StaticAnalysisConnectors, OneOf_FrequencyAnalysisConnectors, OneOf_DynamicAnalysisConnectors
{
    /// <summary>Connect multiple bodies via a virtual bolt Usage: Define a separate bolt connector item for each virtual boltAssign e...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOLT_CONNECTOR";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Select your desired type of fastenerBolt and nut - a virtual connection between a bolt head and nut locationScrew - a...</summary>
    [JsonPropertyName("boltType")]
    public string? BoltType { get; set; }

    [JsonPropertyName("shankDiameter")]
    public Dimensional_Length? ShankDiameter { get; set; }

    [JsonPropertyName("mechanicalProperties")]
    public BoltMechanicalProperties? MechanicalProperties { get; set; }

    /// <summary>Enable the definition of pretension within the virtual bolt.</summary>
    [JsonPropertyName("enableBoltPreload")]
    public bool? EnableBoltPreload { get; set; }

    [JsonPropertyName("preload")]
    public ForcePreload? Preload { get; set; }

    [JsonPropertyName("advancedBoltSettings")]
    public AdvancedConnectorSettings? AdvancedBoltSettings { get; set; }

    [JsonPropertyName("masterTopologicalReference")]
    public TopologicalReference? MasterTopologicalReference { get; set; }

    [JsonPropertyName("slaveTopologicalReference")]
    public TopologicalReference? SlaveTopologicalReference { get; set; }

}
