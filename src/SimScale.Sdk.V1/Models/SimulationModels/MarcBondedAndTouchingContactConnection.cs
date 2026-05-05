using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Define the physical nature of the connection between bodies.Glued: Parts are permanently bonded. No sliding or separation is allowed. Interfaces are treated as a continuous material transition.Note: Parts that are initially separated but come into contact during deformation will also be glued together locally once contact is established.Touching: Parts can slide and separate but cannot penetrate each other. Friction coefficients apply here.Glued + Touching: Use this for bodies which have both contact areas which behave glued and others which should be modeled as touching. Use the &amp;quot;touching faces&amp;quot; to define faces which should exhibit a &amp;quot;touching&amp;quot; behavior during contact.Note: Self-contact can be modeled by assigning a single volume to a contact definition.</summary>
public class MarcBondedAndTouchingContactConnection : OneOf_MarcConnectionGroupConnections
{
    /// <summary>Define the physical nature of the connection between bodies.Glued: Parts are permanently bonded. No sliding or separa...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "BONDED_AND_TOUCHING";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("positionTolerance")]
    public OneOf_MarcBondedAndTouchingContactConnectionPositionTolerance? PositionTolerance { get; set; }

    /// <summary>The Friction coefficient (&amp;mu;) defines the proportionality between the normal contact force and the maximum allo...</summary>
    [JsonPropertyName("frictionCoefficient")]
    public double? FrictionCoefficient { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("contactBodies")]
    public TopologicalReference? ContactBodies { get; set; }

    [JsonPropertyName("touchingFaces")]
    public TopologicalReference? TouchingFaces { get; set; }

}
