using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>This shows the face of the external flow domain to which this boundary condition is assigned. The name of the face reflects its alignment with respect to the orientation cube seen in the viewer.</summary>
[JsonConverter(typeof(OneOf_FlowDomainBoundariesZMINConverter))]
public interface OneOf_FlowDomainBoundariesZMIN { }

internal class OneOf_FlowDomainBoundariesZMINConverter : JsonConverter<OneOf_FlowDomainBoundariesZMIN>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["VELOCITY_INLET_V3"] = typeof(VelocityInletBC),
        ["PRESSURE_OUTLET_V30"] = typeof(PressureOutletBC),
        ["WALL_V34"] = typeof(WallBC),
        ["PERIODIC"] = typeof(PeriodicBC),
        ["ATMOSPHERIC_BOUNDARY_LAYER_INLET"] = typeof(AtmosphericBoundaryLayerInletBC),
    };

    public override OneOf_FlowDomainBoundariesZMIN? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FlowDomainBoundariesZMIN?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FlowDomainBoundariesZMIN value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
