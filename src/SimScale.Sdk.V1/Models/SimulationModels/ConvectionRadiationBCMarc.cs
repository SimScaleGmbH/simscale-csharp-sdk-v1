using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a heat flux boundary condition combining convection and radiation on the selected face groups. It is defined by a common reference temperature (surrounding/sink temperature), the heat transfer coefficient (convective part) and the emissivity (radiative part).Important remarks: The heat transfer coefficient is not only a property of the surrounding fluid but also of the flow.The emissivity takes values between 0 and 1: a value of 1 represents blackbody radiation, while the default value of 0 disables the radiative contribution, leaving a pure convection boundary condition.Radiation is considered diffuse and gray (no dependency on the rotational angle or wavelength).If the reference temperature is higher than the computed temperature on the boundary, heat flux enters the body; for lower values, heat flux leaves the body.You may define a time dependent value by defining a formula or uploading a table (csv-file) for the reference temperature, the heat transfer coefficient and the emissivity.</summary>
public class ConvectionRadiationBCMarc : OneOf_MarcAnalysisBoundaryConditions
{
    /// <summary>This is a heat flux boundary condition combining convection and radiation on the selected face groups. It is defined...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTION_RADIATION";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public DimensionalFunction_Temperature? ReferenceTemperature { get; set; }

    [JsonPropertyName("heatTransferCoefficient")]
    public DimensionalFunction_ThermalTransmittance? HeatTransferCoefficient { get; set; }

    [JsonPropertyName("emissivity")]
    public DimensionalFunction_Dimensionless? Emissivity { get; set; }

    /// <summary>Turn this option on to assign this boundary condition or contact to specific load steps in your simulation. When enab...</summary>
    [JsonPropertyName("activateLoadSteps")]
    public bool? ActivateLoadSteps { get; set; }

    [JsonPropertyName("loadStepUuids")]
    public List<Guid>? LoadStepUuids { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
