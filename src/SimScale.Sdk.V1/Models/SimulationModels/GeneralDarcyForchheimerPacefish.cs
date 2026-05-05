using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class GeneralDarcyForchheimerPacefish : OneOf_AdvancedModellingPorousObjects
{
    /// <summary>Schema name: GeneralDarcyForchheimerPacefish</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GENERAL_POROSITY";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("darcyForchheimerType")]
    public OneOf_GeneralDarcyForchheimerPacefishDarcyForchheimerType? DarcyForchheimerType { get; set; }

    [JsonPropertyName("permeability")]
    public Dimensional_Area? Permeability { get; set; }

    /// <summary>Friction form coefficient defines the pressure losses due to inertial effects through the porous object. The greater...</summary>
    [JsonPropertyName("frictionFormCoefficient")]
    public double? FrictionFormCoefficient { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
