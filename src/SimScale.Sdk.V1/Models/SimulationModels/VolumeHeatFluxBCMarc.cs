using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a volume heat source boundary condition. It is applied to the volume elements in the selected volumes or volume groups.Important remarks: The total heat generated depends on the volume of the selection as the value is given as Watt per cubic meter.For positive values heat is generated, for negative values the bc represents a heat sink.You may define a parameter dependent (x,y,z,t) value by defining a formula or uploading a table (csv-file)</summary>
public class VolumeHeatFluxBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This is a volume heat source boundary condition. It is applied to the volume elements in the selected volumes or volu...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "VOLUME_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("heatfluxValue")]
    public DimensionalFunction_VolumetricPower? HeatfluxValue { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
