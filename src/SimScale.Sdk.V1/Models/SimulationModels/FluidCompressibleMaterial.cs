using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class FluidCompressibleMaterial : OneOf_ConvectiveHeatTransferMaterialsFluids, OneOf_SimericsMaterialsFluids, OneOf_CoupledConjugateHeatTransferMaterialsFluids
{
    /// <summary>Schema name: FluidCompressibleMaterial</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "COMPRESSIBLE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fluidType")]
    public OneOf_FluidCompressibleMaterialFluidType? FluidType { get; set; }

    /// <summary>Select the corresponding phase for this material:Phase 0 would mean this material is represented by the phase fractio...</summary>
    [JsonPropertyName("associatedPhase")]
    public string? AssociatedPhase { get; set; }

    [JsonPropertyName("specie")]
    public SpecieDefault? Specie { get; set; }

    [JsonPropertyName("transport")]
    public OneOf_FluidCompressibleMaterialTransport? Transport { get; set; }

    [JsonPropertyName("viscosityModel")]
    public OneOf_FluidCompressibleMaterialViscosityModel? ViscosityModel { get; set; }

    [JsonPropertyName("laminarPrandtlNumberFunction")]
    public DimensionalFunction_Dimensionless? LaminarPrandtlNumberFunction { get; set; }

    /// <summary>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</summary>
    [JsonPropertyName("turbulentPrandtlNumber")]
    public double? TurbulentPrandtlNumber { get; set; }

    /// <summary>The Schmidt number is a dimensionless number defined as the ratio of viscous diffusion to molecular mass diffusion. I...</summary>
    [JsonPropertyName("schmidtNumber")]
    public double? SchmidtNumber { get; set; }

    [JsonPropertyName("specificHeatFunction")]
    public DimensionalFunction_SpecificHeat? SpecificHeatFunction { get; set; }

    [JsonPropertyName("equationOfState")]
    public OneOf_FluidCompressibleMaterialEquationOfState? EquationOfState { get; set; }

    [JsonPropertyName("radiativeBehavior")]
    public TransparentMaterial? RadiativeBehavior { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

    [JsonPropertyName("geometryPrimitiveUuids")]
    public List<Guid>? GeometryPrimitiveUuids { get; set; }

    [JsonPropertyName("builtInMaterial")]
    public string? BuiltInMaterial { get; set; }

    [JsonPropertyName("materialLibraryReference")]
    public MaterialLibraryReference? MaterialLibraryReference { get; set; }

}
