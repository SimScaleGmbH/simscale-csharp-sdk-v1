using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ScalarTransportResultControl
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("diffusionCoefficient")]
    public double? DiffusionCoefficient { get; set; }

    [JsonPropertyName("volumeMode")]
    public string? VolumeMode { get; set; }

    [JsonPropertyName("su")]
    public double? Su { get; set; }

    [JsonPropertyName("sp")]
    public double? Sp { get; set; }

    [JsonPropertyName("writeControl")]
    public OneOf_ScalarTransportResultControlWriteControl? WriteControl { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

}
