using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class SolidCompressibleMaterial
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("specie")]
    public SpecieDefault? Specie { get; set; }

    [JsonPropertyName("transport")]
    public OneOf_SolidCompressibleMaterialTransport? Transport { get; set; }

    [JsonPropertyName("emissivity")]
    public double? Emissivity { get; set; }

    [JsonPropertyName("radiativeBehavior")]
    public OneOf_SolidCompressibleMaterialRadiativeBehavior? RadiativeBehavior { get; set; }

    [JsonPropertyName("electricConductivityType")]
    public OneOf_SolidCompressibleMaterialElectricConductivityType? ElectricConductivityType { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("builtInMaterial")]
    public string? BuiltInMaterial { get; set; }

    [JsonPropertyName("materialLibraryReference")]
    public MaterialLibraryReference? MaterialLibraryReference { get; set; }

}
