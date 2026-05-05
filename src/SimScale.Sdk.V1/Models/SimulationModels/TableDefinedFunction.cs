using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

public class TableDefinedFunction : OneOf_DimensionalFunction_ElectricConductivityValue, OneOf_DimensionalFunction_ElectricPotentialValue, OneOf_DimensionalFunction_DimensionlessValue, OneOf_DimensionalFunction_KinematicViscosityValue, OneOf_DimensionalFunction_ElectricCurrentValue, OneOf_DimensionalFunction_ThermalExpansionRateValue, OneOf_DimensionalFunction_AccelerationValue, OneOf_DimensionalFunction_ThermalTransmittanceValue, OneOf_BilinearElastoPlasticModelPoissonsRatio, OneOf_DimensionalFunction_SpecificTurbulenceDissipationRateValue, OneOf_DimensionalFunction_AngleValue, OneOf_DimensionalFunction_ThermalConductivityValue, OneOf_DimensionalFunction_SpeedValue, OneOf_ComponentVectorFunctionX, OneOf_ComponentVectorFunctionY, OneOf_ComponentVectorFunctionZ, OneOf_DimensionalFunction_TurbulenceKineticEnergyValue, OneOf_DimensionalFunction_PowerValue, OneOf_DimensionalFunction_TemperatureValue, OneOf_IsotropicPlasticHardeningPoissonsRatio, OneOf_JohnsonCookElastoPlasticModelPoissonsRatio, OneOf_IsotropicDirectionalDependencyPoissonsRatio, OneOf_LinearElasticMarcMaterialBehaviorPoissonsRatio, OneOf_DimensionalFunction_VolumetricPowerValue, OneOf_DimensionalFunction_SpecificEnergyValue, OneOf_DimensionalFunction_DynamicViscosityValue, OneOf_DimensionalFunction_ElectricFieldStrengthValue, OneOf_DimensionalFunction_TemperatureGradientValue, OneOf_DimensionalFunction_TurbulentDissipationValue, OneOf_DimensionalFunction_TimeValue, OneOf_DimensionalFunction_DensityValue, OneOf_DimensionalFunction_LengthValue, OneOf_DimensionalFunction_MagneticFluxDensityValue, OneOf_ElasticityMarcPoissonsRatio, OneOf_DimensionalFunction_HeatFluxValue, OneOf_PrescribedOptionalFunctionValue, OneOf_DimensionalFunction_RotationSpeedValue, OneOf_DimensionalFunction_ElectricResistivityValue, OneOf_DimensionalFunction_VolumetricFlowRateValue, OneOf_DimensionalFunction_TotalThermalTransmittanceValue, OneOf_DimensionalFunction_MassFlowRateValue, OneOf_DimensionalFunction_SpecificHeatValue, OneOf_DimensionalFunction_PressureValue, OneOf_StressTensor_PressureSigmaXX, OneOf_StressTensor_PressureSigmaYY, OneOf_StressTensor_PressureSigmaZZ, OneOf_StressTensor_PressureSigmaYZ, OneOf_StressTensor_PressureSigmaXZ, OneOf_StressTensor_PressureSigmaXY, OneOf_OrthotropicDirectionalDependencyPoissonsRatioXY, OneOf_OrthotropicDirectionalDependencyPoissonsRatioYZ, OneOf_OrthotropicDirectionalDependencyPoissonsRatioXZ
{
    /// <summary>Schema name: TableDefinedFunction</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "TABLE_DEFINED";

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The ID of the imported table.</summary>
    [JsonPropertyName("tableId")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Guid TableId { get; set; }

    /// <summary>Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set...</summary>
    [JsonPropertyName("resultIndex")]
    public List<int>? ResultIndex { get; set; }

    [JsonPropertyName("independentVariables")]
    public List<TableFunctionParameter>? IndependentVariables { get; set; }

    /// <summary>Values in each row are separated by this character. Also known as a delimiter.</summary>
    [JsonPropertyName("separator")]
    public string? Separator { get; set; }

    [JsonPropertyName("outOfBounds")]
    public string? OutOfBounds { get; set; }

    [JsonPropertyName("interpolation")]
    public string? Interpolation { get; set; }

    [JsonPropertyName("leftExtrapolation")]
    public string? LeftExtrapolation { get; set; }

    [JsonPropertyName("rightExtrapolation")]
    public string? RightExtrapolation { get; set; }

}
