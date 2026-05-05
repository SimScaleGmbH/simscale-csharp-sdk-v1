using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ComputingCore
{
    /// <summary>Selecting more processor cores will speed up the simulation process. Choosing a smaller computation instance will sav...</summary>
    [JsonPropertyName("numOfProcessors")]
    public long? NumOfProcessors { get; set; }

    /// <summary>Set the number of processors which shall be used for the parallel computation.</summary>
    [JsonPropertyName("numOfComputingProcessors")]
    public int? NumOfComputingProcessors { get; set; }

    [JsonPropertyName("domainDecomposition")]
    public OneOf_ComputingCoreDomainDecomposition? DomainDecomposition { get; set; }

    [JsonPropertyName("numOfThreads")]
    public int? NumOfThreads { get; set; }

    [JsonPropertyName("partitionMesh")]
    public bool? PartitionMesh { get; set; }

}
