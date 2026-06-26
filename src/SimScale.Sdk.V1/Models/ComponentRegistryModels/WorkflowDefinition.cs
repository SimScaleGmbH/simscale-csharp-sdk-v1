using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models.WorkflowsModels;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Simulation workflow definition. The definition follows the semantics of a workflow, which is a set of connected operations to generate some desired output data from available input data. The workflow developer defines the data and operations and the workflow engine executes the workflow to achieve the declared goal. Within the entire definition all data and operations are named. This drives the attention towards the semantics and the domain, also helps with communicating the state of the execution. In regard to consistency validation (name duplications etc.), the framework takes care of that.</summary>
public class WorkflowDefinition
{
    [JsonPropertyName("breakpoints")]
    public List<Breakpoint>? Breakpoints { get; set; }

    [JsonPropertyName("data")]
    public List<JsonElement>? Data { get; set; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, JsonElement>? Metadata { get; set; }

    [JsonPropertyName("operations")]
    public List<JsonElement>? Operations { get; set; }

    /// <summary>Possible strategies for analysing the workflow definition.</summary>
    [JsonPropertyName("workflowDefinitionAnalysisStrategy")]
    public string? WorkflowDefinitionAnalysisStrategy { get; set; }

    /// <summary>Possible workflow topologies.</summary>
    [JsonPropertyName("workflowTopology")]
    public string? WorkflowTopology { get; set; }

}
