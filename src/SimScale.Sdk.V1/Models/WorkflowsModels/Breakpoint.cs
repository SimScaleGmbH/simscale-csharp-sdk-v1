using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Breakpoints provide an automated mechanism to pause a workflow run based on certain criteria. Based on the criteria the following cases are possible: * operation only breakpoint: the workflow gets automatically paused when the workflow run would get to the processing of a particular operation * condition only breakpoint: the workflow gets automatically paused when the particular condition (expressed as a boolean value model) becomes true * operation with condition breakpoint: the workflow gets automatically paused when the workflow run gets to the processing of a particular operation and also the additional condition is met In all cases, whenever a breakpoints get activated, the workflow executor puts the workflow run into paused state and not scheduling any further operation processing until the workflow run is resumed explicitly by the user. That's also true for those operations which has no associated activated breakpoint, in other words, there's no concept of "multi-threading" in workflows in the sense of pausing one "thread" and keeping others running, even if when the run is ongoing maximum parallelism is aimed by the workflow executor. Note that already running operations are allowed to finish and to be processed in case of breakpoint activation, but after their processing the workflow run is completely paused and not reprocessed for other potential further operations. Breakpoints can be defined at these levels: * workflow type level: defined as part of the workflow definition by the workflow developer, these breakpoints apply to all workflows and their runs based on top of the particular workflow type * workflow level: users can define workflow specific custom breakpoints which apply only to the particular workflow and its runs * workflow run level: users can also define workflow run specific custom breakpoints which apply only to the particular workflow run</summary>
public class Breakpoint
{
    /// <summary>Value model of a boolean value. Resolves to a JSON boolean or null node.</summary>
    [JsonPropertyName("condition")]
    public JsonElement? Condition { get; set; }

    [JsonPropertyName("doc")]
    public string? Doc { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, Dictionary<string, JsonElement>>? Metadata { get; set; }

    [JsonPropertyName("multiLanguageDoc")]
    public Dictionary<string, string>? MultiLanguageDoc { get; set; }

    [JsonPropertyName("multiLanguageMessage")]
    public Dictionary<string, string>? MultiLanguageMessage { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

}
