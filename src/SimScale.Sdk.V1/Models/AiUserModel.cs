using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class AiUserModel
{
    /// <summary>Possible values are STATIC_ANALYSIS, INCOMPRESSIBLE, COUPLED_CONJUGATE_HEAT_TRANSFER and EMBEDDED_BOUNDARY</summary>
    [JsonPropertyName("analysisType")]
    public string? AnalysisType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Possible values are navasto and ai-solver-kickstart</summary>
    [JsonPropertyName("predictorComponent")]
    public string? PredictorComponent { get; set; }

    [JsonPropertyName("sharedWithOrganization")]
    public bool? SharedWithOrganization { get; set; }

    /// <summary>Possible values are fea_template, cfd_template, chtv2ibm_template, spec_id and spec_and_tesselation</summary>
    [JsonPropertyName("templateName")]
    public string? TemplateName { get; set; }

    [JsonPropertyName("templateParameters")]
    public Dictionary<string, JsonElement>? TemplateParameters { get; set; }

    [JsonPropertyName("aiModelId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid AiModelId { get; set; }

}
