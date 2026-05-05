using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a boundary condition for the temperature variable. It prescribes the given temperature value on all selected groups.Important remarks: Do not define a temperature and a heat flux boundary condition on the same groupDo not define the temperature on slave entities of Contact Constraints as they are constrained by the master temperatureYou may define a parameter dependent (x,y,z,t) value by defining a formula or uploading a table (csv-file)</summary>
public class TemperatureBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This is a boundary condition for the temperature variable. It prescribes the given temperature value on all selected...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TEMPERATURE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("temperatureValue")]
    public DimensionalFunction_Temperature? TemperatureValue { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
