using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class MarcElementTechnology
{
    /// <summary>Select the finite element order to be used for the mesh. Typically, a first-order mesh is sufficient for this analysi...</summary>
    [JsonPropertyName("meshOrder")]
    public string? MeshOrder { get; set; }

}
