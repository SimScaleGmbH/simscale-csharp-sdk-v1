using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidResultControls
{
    [JsonPropertyName("customComfortCriteria")]
    public List<CustomComfortCriterionResultControl>? CustomComfortCriteria { get; set; }

    [JsonPropertyName("forcesMoments")]
    public List<OneOf_FluidResultControlsForcesMoments>? ForcesMoments { get; set; }

    [JsonPropertyName("surfaceData")]
    public List<OneOf_FluidResultControlsSurfaceData>? SurfaceData { get; set; }

    [JsonPropertyName("scalarTransport")]
    public List<ScalarTransportResultControl>? ScalarTransport { get; set; }

    [JsonPropertyName("probePoints")]
    public List<ProbePointsResultControl>? ProbePoints { get; set; }

    [JsonPropertyName("fieldCalculations")]
    public List<OneOf_FluidResultControlsFieldCalculations>? FieldCalculations { get; set; }

    [JsonPropertyName("transientResultControl")]
    public TransientResultControl? TransientResultControl { get; set; }

    [JsonPropertyName("statisticalAveragingResultControl")]
    public StatisticalAveragingResultControlV2? StatisticalAveragingResultControl { get; set; }

    [JsonPropertyName("snapshotResultControl")]
    public SnapshotResultControl? SnapshotResultControl { get; set; }

}
