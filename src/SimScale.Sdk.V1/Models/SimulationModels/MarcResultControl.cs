using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcResultControl
{
    [JsonPropertyName("solutionFields")]
    public List<OneOf_MarcResultControlSolutionFields>? SolutionFields { get; set; }

    /// <summary>Min-max: Identifies and records the absolute minimum and maximum values of the selected field within the designated a...</summary>
    [JsonPropertyName("areaCalculation")]
    public List<OneOf_MarcResultControlAreaCalculation>? AreaCalculation { get; set; }

    /// <summary>Min-max: Identifies and records the absolute minimum and maximum values of the selected field within the designated a...</summary>
    [JsonPropertyName("volumeCalculation")]
    public List<OneOf_MarcResultControlVolumeCalculation>? VolumeCalculation { get; set; }

    [JsonPropertyName("connectorPointData")]
    public List<MarcConnectorPointDataItem>? ConnectorPointData { get; set; }

}
