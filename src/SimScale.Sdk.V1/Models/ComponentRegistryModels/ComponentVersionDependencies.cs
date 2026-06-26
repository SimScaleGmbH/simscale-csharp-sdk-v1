using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ComponentRegistryModels;

/// <summary>Contains the dependencies of a component version, grouped by component type. Note that not all component types can have dependencies of all component types. For instance, data types can only depend on other data types, but not methods or workflows.</summary>
public class ComponentVersionDependencies
{
    [JsonPropertyName("dataTypeDependencies")]
    public List<string>? DataTypeDependencies { get; set; }

    [JsonPropertyName("engineeringAiAgentDependencies")]
    public List<string>? EngineeringAiAgentDependencies { get; set; }

    [JsonPropertyName("methodDependencies")]
    public List<string>? MethodDependencies { get; set; }

    [JsonPropertyName("physicsAiModelDependencies")]
    public List<string>? PhysicsAiModelDependencies { get; set; }

    [JsonPropertyName("workflowTypeDependencies")]
    public List<string>? WorkflowTypeDependencies { get; set; }

}
