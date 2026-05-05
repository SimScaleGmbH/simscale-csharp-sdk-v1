using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConjugateHeatTransferMaterials
{
    [JsonPropertyName("fluids")]
    public List<FluidCompressibleMaterial>? Fluids { get; set; }

    [JsonPropertyName("solids")]
    public List<SolidCompressibleMaterial>? Solids { get; set; }

}
