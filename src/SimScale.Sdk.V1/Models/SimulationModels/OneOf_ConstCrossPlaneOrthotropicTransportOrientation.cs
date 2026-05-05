using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Defines the direction on which the thermal conductivity will act: x-, y-, z-Axis: the cross-plane conductivity acts along the selected coordinate axis and the in-plane conductivity acts on the plane orthogonal to that axis.Custom: the cross-plane conductivity is aligned with the cross-plane orientation defined by the X, Y, Z components, and the in-plane conductivity acts on the plane orthogonal to the cross-plane orientation.</summary>
[JsonConverter(typeof(OneOf_ConstCrossPlaneOrthotropicTransportOrientationConverter))]
public interface OneOf_ConstCrossPlaneOrthotropicTransportOrientation { }

internal class OneOf_ConstCrossPlaneOrthotropicTransportOrientationConverter : JsonConverter<OneOf_ConstCrossPlaneOrthotropicTransportOrientation>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["XAXIS"] = typeof(XAxis),
        ["YAXIS"] = typeof(YAxis),
        ["ZAXIS"] = typeof(ZAxis),
        ["CROSS_PLANE"] = typeof(CrossPlaneCustomOrientation),
    };

    public override OneOf_ConstCrossPlaneOrthotropicTransportOrientation? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ConstCrossPlaneOrthotropicTransportOrientation?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ConstCrossPlaneOrthotropicTransportOrientation value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
