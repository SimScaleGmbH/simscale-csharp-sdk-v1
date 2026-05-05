using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class ConvectiveHeatTransferMaterials
{
    [JsonPropertyName("fluids")]
    public List<OneOf_ConvectiveHeatTransferMaterialsFluids>? Fluids { get; set; }

}
