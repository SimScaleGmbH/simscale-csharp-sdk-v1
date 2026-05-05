using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>CAD import options. Please refer to https://www.simscale.com/docs/cad-preparation/#cad-upload-options for a detailed description of the options.</summary>
public class CadImportRequestOptions
{
    /// <summary>_Facet Split_ tries to split the faceted parts of a CAD model. This means it can create new faces from original faces...</summary>
    [JsonPropertyName("facetSplit")]
    public bool FacetSplit { get; set; } = false;

    /// <summary>_Automatic Sewing_ is sewing faces or sheet bodies together. This means that it can create one new face from two (or...</summary>
    [JsonPropertyName("sewing")]
    public bool Sewing { get; set; } = false;

    /// <summary>This option tries to improve the topology (e.g. edges, vertices) and geometry of the model by adjusting tolerances, s...</summary>
    [JsonPropertyName("improve")]
    public bool Improve { get; set; } = true;

    /// <summary>This option allows you to import a *.stl file that is optimized for the Incompressible LBM and Wind Comfort analysis...</summary>
    [JsonPropertyName("optimizeForLBMSolver")]
    public bool OptimizeForLBMSolver { get; set; } = false;

}
