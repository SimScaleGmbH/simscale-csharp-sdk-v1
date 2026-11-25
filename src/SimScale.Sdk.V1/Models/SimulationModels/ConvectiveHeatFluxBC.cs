using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This is a heat flux boundary condition representing a convective heat flux on the selected face groups. It is defined by the reference temperature (surrounding temperature) and the convection coefficient.Important remarks: The convection coefficient is not only dependent on the material of the surrounding fluid but a property of the flowYou may define a parameter dependent (x,y,z,t) value by defining a formula or uploading a table (csv-file) for the reference temperature and the convection coefficient</summary>
public class ConvectiveHeatFluxBC : OneOf_HeatTransferBoundaryConditions, OneOf_ThermalMechanicalBoundaryConditions
{
    /// <summary>This is a heat flux boundary condition representing a convective heat flux on the selected face groups. It is defined...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONVECTIVE_HEAT_FLUX";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("referenceTemperature")]
    public DimensionalFunction_Temperature? ReferenceTemperature { get; set; }

    [JsonPropertyName("heatTransferCoefficient")]
    public DimensionalFunction_ThermalTransmittance? HeatTransferCoefficient { get; set; }

    [JsonPropertyName("topologicalReference")]
    public TopologicalReference? TopologicalReference { get; set; }

}
