using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>General formulation that does not depend on the shape of the holes. Valid only for thin plates where thickness to hole ratio is less than 0.015 and Reynolds number is greater than 10000.</summary>
public class GeneralHoleShape : OneOf_PlateDataHoleShape
{
    /// <summary>General formulation that does not depend on the shape of the holes. Valid only for thin plates where thickness to hol...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "GENERAL";

}
