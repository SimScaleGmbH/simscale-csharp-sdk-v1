using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The thermal conductivity of a material is a measure of its ability to conduct heat.Isotropic: the thermal conductivity &amp;kappa; is the same in all directions.Orthotropic: the thermal conductivity is unique and independent in three orthogonal directions. It is defined by &amp;kappa;x, &amp;kappa;y, and &amp;kappa;z.Cross-plane orthotropic: it is defined by an in-plane conductivity, which is an isotropic conductivity on a given plane, and a cross-plane&amp;nbsp;conductivity, which acts in the direction normal to the aforementioned plane.</summary>
public class ConstAnIsoTransport : OneOf_SolidCompressibleMaterialTransport
{
    /// <summary>The thermal conductivity of a material is a measure of its ability to conduct heat.Isotropic: the thermal conductivit...</summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "CONST_AN_ISO";

    [JsonPropertyName("conductivity")]
    public OrthotropicConductivity? Conductivity { get; set; }

    [JsonPropertyName("orientation")]
    public OneOf_ConstAnIsoTransportOrientation? Orientation { get; set; }

    [JsonPropertyName("thermo")]
    public HConstThermo? Thermo { get; set; }

}
