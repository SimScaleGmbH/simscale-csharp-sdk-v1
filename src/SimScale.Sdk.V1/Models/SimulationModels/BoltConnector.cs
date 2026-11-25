using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Connects parts through a virtual bolt, so the bolt and nut are not part of the CAD model. Define one bolt connector per bolt.Assign, all centred on one axis:Bolt head assignment: the faces or edges where the head sits, all on one partNut assignment: the faces or edges where the nut sits, all on one part (for a Screw, the threaded hole instead, see Bolt type)The virtual bolt is a beam between the centres of the two assignments, with the Shank diameter and Mechanical properties you enter. It can carry a preload. Learn more</summary>
public class BoltConnector : OneOf_DynamicAnalysisConnectors, OneOf_FrequencyAnalysisConnectors, OneOf_StaticAnalysisConnectors, OneOf_HarmonicAnalysisConnectors
{
    /// <summary>Connects parts through a virtual bolt, so the bolt and nut are not part of the CAD model. Define one bolt connector p...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BOLT_CONNECTOR";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Select the type of fastener:Bolt and nut: the bolt goes through all parts. Assign where the head sits and where the n...</summary>
    [JsonPropertyName("boltType")]
    public string? BoltType { get; set; }

    [JsonPropertyName("shankDiameter")]
    public Dimensional_Length? ShankDiameter { get; set; }

    [JsonPropertyName("mechanicalProperties")]
    public BoltMechanicalProperties? MechanicalProperties { get; set; }

    /// <summary>Tightens the virtual bolt with a Pretension force before the loads are applied.</summary>
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
