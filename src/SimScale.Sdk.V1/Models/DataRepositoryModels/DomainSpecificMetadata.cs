using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Domain-specific metadata of a data object. A free-form JSON object whose shape is defined by the metadata schema of the data type.</summary>
public class DomainSpecificMetadata : Dictionary<string, JsonElement>
{
}
