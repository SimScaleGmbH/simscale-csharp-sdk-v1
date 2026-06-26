using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Contains the component versions dependent on a component version, grouped by component type. Note that not all component types can have dependents of all component types. For instance, data types cannot depend on methods or workflow types.</summary>
public class ComponentVersionDependents
{
    [JsonPropertyName("dataTypeDependents")]
    public List<string>? DataTypeDependents { get; set; }

    [JsonPropertyName("engineeringAiAgentDependents")]
    public List<string>? EngineeringAiAgentDependents { get; set; }

    [JsonPropertyName("methodDependents")]
    public List<string>? MethodDependents { get; set; }

    [JsonPropertyName("physicsAiModelDependents")]
    public List<string>? PhysicsAiModelDependents { get; set; }

    [JsonPropertyName("workflowTypeDependents")]
    public List<string>? WorkflowTypeDependents { get; set; }

}
