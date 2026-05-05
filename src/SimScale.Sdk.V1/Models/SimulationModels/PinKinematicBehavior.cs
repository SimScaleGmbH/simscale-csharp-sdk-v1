using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class PinKinematicBehavior
{
    [JsonPropertyName("rotation")]
    public OneOf_PinKinematicBehaviorRotation? Rotation { get; set; }

    [JsonPropertyName("axialTranslation")]
    public OneOf_PinKinematicBehaviorAxialTranslation? AxialTranslation { get; set; }

}
