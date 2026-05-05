using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ReportingModels;

public class Filters
{
    [JsonPropertyName("cuttingPlanes")]
    public List<CuttingPlane>? CuttingPlanes { get; set; }

    [JsonPropertyName("isoSurfaces")]
    public List<IsoSurface>? IsoSurfaces { get; set; }

    [JsonPropertyName("isoVolumes")]
    public List<IsoVolume>? IsoVolumes { get; set; }

    [JsonPropertyName("displacement")]
    public Displacement? Displacement { get; set; }

    [JsonPropertyName("particleTraces")]
    public List<ParticleTrace>? ParticleTraces { get; set; }

}
