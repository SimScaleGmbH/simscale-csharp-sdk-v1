using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.CadModels;

/// <summary>Translation method.</summary>
public class TranslateGroupParameter
{
    /// <summary>Defines the parameter set used to define the extrusion. It can be either: - `translate_vector`, in which case the tra...</summary>
    [JsonPropertyName("selected")]
    [JsonRequired]
    public required string Selected { get; set; }

    [JsonPropertyName("translation_vector")]
    public VectorWithUnit? TranslationVector { get; set; }

    /// <summary>Face limiting the translation.</summary>
    [JsonPropertyName("translation_face")]
    public string? TranslationFace { get; set; }

}
