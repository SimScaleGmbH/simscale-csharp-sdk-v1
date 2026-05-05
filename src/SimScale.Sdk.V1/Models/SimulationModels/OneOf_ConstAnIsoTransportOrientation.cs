using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines the direction on which the thermal conductivity will act: Cartesian: the conductivities &amp;kappa;x, &amp;kappa;y, and &amp;kappa;z are aligned with the X, Y, and Z-axis, respectively.Custom: the conductivities &amp;kappa;x and &amp;kappa;y are aligned with the unit vectors x and y, respectively, and the conductivity &amp;kappa;z is aligned with the resultant of the cross product of unit vectors x and y.</summary>
[JsonConverter(typeof(OneOf_ConstAnIsoTransportOrientationConverter))]
public interface OneOf_ConstAnIsoTransportOrientation { }

internal class OneOf_ConstAnIsoTransportOrientationConverter : JsonConverter<OneOf_ConstAnIsoTransportOrientation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CARTESIAN"] = typeof(CartesianOrientation),
        ["CUSTOM"] = typeof(CustomOrientation),
    };

    public override OneOf_ConstAnIsoTransportOrientation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ConstAnIsoTransportOrientation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ConstAnIsoTransportOrientation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
