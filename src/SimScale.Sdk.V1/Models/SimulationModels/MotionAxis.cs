using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MotionAxis
{
    /// <summary>The coordinate system the direction below is written in. Leave it empty to use the global Cartesian system.Only Carte...</summary>
    [JsonPropertyName("coordinateSystem")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid CoordinateSystem { get; set; }

    [JsonPropertyName("direction")]
    public DimensionalVector_Dimensionless? Direction { get; set; }

    [JsonPropertyName("initialVelocity")]
    public Dimensional_Speed? InitialVelocity { get; set; }

    [JsonPropertyName("travelLimit")]
    public OneOf_MotionAxisTravelLimit? TravelLimit { get; set; }

}
