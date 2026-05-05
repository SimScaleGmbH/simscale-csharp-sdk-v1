using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class HydrostaticIsothermalFreestreamPBC : OneOf_FreestreamVBCAmbientPressure
{
    /// <summary>Schema name: HydrostaticIsothermalFreestreamPBC</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "HYDROSTATIC_ISOTHERMAL_FREESTREAM_PRESSURE";

    [JsonPropertyName("ambientStaticPressure")]
    public Dimensional_Pressure? AmbientStaticPressure { get; set; }

}
