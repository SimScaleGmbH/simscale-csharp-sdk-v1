using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_ConjugateHeatTransferBoundaryConditionsConverter))]
public interface OneOf_ConjugateHeatTransferBoundaryConditions { }

internal class OneOf_ConjugateHeatTransferBoundaryConditionsConverter : JsonConverter<OneOf_ConjugateHeatTransferBoundaryConditions>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["VELOCITY_INLET_V3"] = typeof(VelocityInletBC),
        ["VELOCITY_OUTLET_V7"] = typeof(VelocityOutletBC),
        ["PRESSURE_INLET_V31"] = typeof(PressureInletBC),
        ["PRESSURE_OUTLET_V30"] = typeof(PressureOutletBC),
        ["WALL_V34"] = typeof(WallBC),
        ["FAN"] = typeof(FanBC),
        ["SYMMETRY"] = typeof(SymmetryBC),
        ["WEDGE"] = typeof(WedgeBC),
        ["CUSTOM_V37"] = typeof(CustomFluidBC),
        ["EMPTY_2D"] = typeof(Empty2DBC),
        ["NATURAL_CONVECTION_INLET_OUTLET"] = typeof(NaturalConvectionInletOutletBC),
    };

    public override OneOf_ConjugateHeatTransferBoundaryConditions? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ConjugateHeatTransferBoundaryConditions?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ConjugateHeatTransferBoundaryConditions value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
