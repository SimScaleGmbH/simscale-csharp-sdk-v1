using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_DynamicAnalysisBoundaryConditionsConverter))]
public interface OneOf_DynamicAnalysisBoundaryConditions { }

internal class OneOf_DynamicAnalysisBoundaryConditionsConverter : JsonConverter<OneOf_DynamicAnalysisBoundaryConditions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["BOLT_PRELOAD"] = typeof(BoltPreloadBC),
        ["ELASTIC_SUPPORT"] = typeof(ElasticSupportBC),
        ["FIXED_SUPPORT"] = typeof(FixedSupportBC),
        ["FIXED_VALUE"] = typeof(FixedValueBC),
        ["POINT_MASS"] = typeof(PointMassBC),
        ["DISTRIBUTED_MASS"] = typeof(DistributedMassBC),
        ["REMOTE_DISPLACEMENT_LOAD"] = typeof(RemoteDisplacementLoadBC),
        ["ROTATING_MOTION"] = typeof(RotatingMotionBC),
        ["SYMMETRY_PLANE"] = typeof(SymmetryPlaneBC),
        ["CYCLIC_SYMMETRY"] = typeof(CyclicSymmetryBC),
        ["CENTRIFUGAL_FORCE"] = typeof(CentrifugalForceBC),
        ["FOLLOWER_PRESSURE"] = typeof(FollowerPressureBC),
        ["FORCE_LOAD"] = typeof(ForceLoadBC),
        ["NODAL_LOAD"] = typeof(NodalLoadBC),
        ["PRESSURE"] = typeof(PressureBC),
        ["REMOTE_FORCE_LOAD"] = typeof(RemoteForceLoadBC),
        ["SURFACE_LOAD"] = typeof(SurfaceLoadBC),
        ["VOLUME_LOAD"] = typeof(VolumeLoadBC),
        ["HINGE_CONSTRAINT"] = typeof(HingeConstraintBC),
    };

    public override OneOf_DynamicAnalysisBoundaryConditions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_DynamicAnalysisBoundaryConditions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_DynamicAnalysisBoundaryConditions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
