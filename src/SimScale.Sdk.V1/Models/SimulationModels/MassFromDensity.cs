using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MassFromDensity : OneOf_ComputedTranslationalMotionMassDefinition
{
    /// <summary>Schema name: MassFromDensity</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "MASS_FROM_DENSITY";

    [JsonPropertyName("addedMass")]
    public Dimensional_Mass? AddedMass { get; set; }

}
