using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class WindComfort : Analysis
{
    /// <summary>Schema name: WindComfort</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "WIND_COMFORT";

    [JsonPropertyName("regionOfInterest")]
    public RegionOfInterest? RegionOfInterest { get; set; }

    [JsonPropertyName("windConditions")]
    public WindConditions? WindConditions { get; set; }

    [JsonPropertyName("pedestrianComfortMap")]
    public List<PedestrianComfortSurface>? PedestrianComfortMap { get; set; }

    [JsonPropertyName("simulationControl")]
    public WindComfortSimulationControl? SimulationControl { get; set; }

    [JsonPropertyName("advancedModelling")]
    public AdvancedModelling? AdvancedModelling { get; set; }

    [JsonPropertyName("additionalResultExport")]
    public FluidResultControls? AdditionalResultExport { get; set; }

    [JsonPropertyName("meshSettings")]
    public WindComfortMesh? MeshSettings { get; set; }

}
