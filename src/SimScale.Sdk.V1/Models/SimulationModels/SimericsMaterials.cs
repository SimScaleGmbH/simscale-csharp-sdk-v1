using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SimericsMaterials
{
    [JsonPropertyName("fluids")]
    public List<OneOf_SimericsMaterialsFluids>? Fluids { get; set; }

    [JsonPropertyName("solids")]
    public List<SolidCompressibleMaterial>? Solids { get; set; }

}
