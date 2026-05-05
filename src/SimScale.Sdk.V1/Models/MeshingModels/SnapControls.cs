using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.MeshingModels;

public class SnapControls
{
    /// <summary>Define the max number of iterations to ensure that the mesh conforms to the geometry. Higher values lead to a better...</summary>
    [JsonPropertyName("meshToGeometryConformationIterations")]
    public int? MeshToGeometryConformationIterations { get; set; }

    /// <summary>This parameter describes a distance (relative to the local maximum mesh edge length) within which the algorithm looks...</summary>
    [JsonPropertyName("tolerance")]
    public double? Tolerance { get; set; }

    /// <summary>This parameter defines the number of displacement relaxation iterations during the meshing process. Higher values lea...</summary>
    [JsonPropertyName("solverIterations")]
    public int? SolverIterations { get; set; }

    /// <summary>This parameter defines the max number of iterations to remove bad mesh points (see documentation).</summary>
    [JsonPropertyName("relaxIterations")]
    public int? RelaxIterations { get; set; }

    /// <summary>This parameter defines the max number of iterations done to ensure that the mesh conforms to the geometry.</summary>
    [JsonPropertyName("maxMexConformationIterations")]
    public int? MaxMexConformationIterations { get; set; }

    /// <summary>Activating this makes the snapping algorithm detecting geometrical features by sampling the surface. This might be ti...</summary>
    [JsonPropertyName("implicitFeatureSnap")]
    public bool? ImplicitFeatureSnap { get; set; }

    /// <summary>Use the explicitly given feature refinements for feature snapping. An explicit feature refinement can be added under...</summary>
    [JsonPropertyName("explicitFeatureSnap")]
    public bool? ExplicitFeatureSnap { get; set; }

    /// <summary>Also detect features between multiple surfaces. This is relevant when you want to create a mesh with multiple regions...</summary>
    [JsonPropertyName("detectFeaturesBetweenMultipleSurfaces")]
    public bool? DetectFeaturesBetweenMultipleSurfaces { get; set; }

}
