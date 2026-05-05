using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class LoadStep
{
    /// <summary>Schema name: LoadStep</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "LOAD_STEP";

    [JsonPropertyName("id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("duration")]
    public Dimensional_Time? Duration { get; set; }

}
