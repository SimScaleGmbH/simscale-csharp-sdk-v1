using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowRepositoryModels;

public class ErrorDetails
{
    [JsonPropertyName("parameters")]
    public List<ErrorParameter>? Parameters { get; set; }

}
