using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

/// <summary>Out-of-range colors apply to an individual scalar, overriding what the state saved for it (including states/views with out-of-range colors switched off). This override requires the target field name. The colors are a per-scalar setting, a state can carry settings for several scalars. The target scalar can be one that has been applied to the model itself, globally, or one that was applied on a cutting plane, isosurface, isovolume or particle-trace. The override is considered valid only if the target scalar is in fact applied to either the model or a filter in the state/view, otherwise it will be rejected. This applies to automatic, manual and default states/vies.</summary>
public class OutOfRangeColorOverride
{
    [JsonPropertyName("scalarField")]
    [JsonRequired]
    public required ScalarField ScalarField { get; set; }

    [JsonPropertyName("belowRangeColor")]
    public Color? BelowRangeColor { get; set; }

    [JsonPropertyName("aboveRangeColor")]
    public Color? AboveRangeColor { get; set; }

}
