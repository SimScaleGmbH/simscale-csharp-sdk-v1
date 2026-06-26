using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class IncompressibleMaterial : OneOf_ConvectiveHeatTransferMaterialsFluids, OneOf_CoupledConjugateHeatTransferMaterialsFluids, OneOf_SimericsMaterialsFluids
{
    /// <summary>Schema name: IncompressibleMaterial</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "INCOMPRESSIBLE";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("fluidType")]
    public OneOf_IncompressibleMaterialFluidType? FluidType { get; set; }

    /// <summary>Select the corresponding phase for this material:Phase 0 would mean this material is represented by the phase fractio...</summary>
    [JsonPropertyName("associatedPhase")]
    public string? AssociatedPhase { get; set; }

    [JsonPropertyName("viscosityModel")]
    public OneOf_IncompressibleMaterialViscosityModel? ViscosityModel { get; set; }

    [JsonPropertyName("density")]
    public Dimensional_Density? Density { get; set; }

    [JsonPropertyName("thermalExpansionCoefficient")]
    public Dimensional_ThermalExpansionRate? ThermalExpansionCoefficient { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public Dimensional_Temperature? ReferenceTemperature { get; set; }

    /// <summary>Laminar Prandtl number is used to calculate the heat transfer in the domain.</summary>
    [JsonPropertyName("laminarPrandtlNumber")]
    public double? LaminarPrandtlNumber { get; set; }

    [JsonPropertyName("laminarPrandtlNumberFunction")]
    public DimensionalFunction_Dimensionless? LaminarPrandtlNumberFunction { get; set; }

    /// <summary>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</summary>
    [JsonPropertyName("turbulentPrandtlNumber")]
    public double? TurbulentPrandtlNumber { get; set; }

    [JsonPropertyName("specificHeat")]
    public Dimensional_SpecificHeat? SpecificHeat { get; set; }

    [JsonPropertyName("specificHeatFunction")]
    public DimensionalFunction_SpecificHeat? SpecificHeatFunction { get; set; }

    [JsonPropertyName("molarWeight")]
    public Dimensional_MolarMass? MolarWeight { get; set; }

    [JsonPropertyName("cavitation")]
    public Cavitation? Cavitation { get; set; }

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
