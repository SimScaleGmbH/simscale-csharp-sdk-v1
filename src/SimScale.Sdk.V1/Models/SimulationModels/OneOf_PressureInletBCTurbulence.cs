using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>These options specify inlet boundary conditions for turbulence quantities: Automatic considers a value of 0.05 for turbulent intensity (I). The turbulent mixing length (L) is calculated as 0.07Dh, where Dh is the hydraulic diameter of the boundary face.Turbulent intensity and mixing length allows to specify these values directly.Fixed value allows to specify the values of the turbulent kinetic energy (k) and the turbulent dissipation rate (&amp;#120656) or the specific dissipation rate (&amp;#969).</summary>
[JsonConverter(typeof(OneOf_PressureInletBCTurbulenceConverter))]
public interface OneOf_PressureInletBCTurbulence { }

internal class OneOf_PressureInletBCTurbulenceConverter : JsonConverter<OneOf_PressureInletBCTurbulence>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC_TURBULENCE"] = typeof(AutomaticTurbulence),
        ["TURBULENT_INTENSITY_AND_REFERENCE_LENGTH_TURBULENCE"] = typeof(TurbulentIntensityAndReferenceLengthTurbulence),
        ["FIXED_VALUE_TURBULENCE"] = typeof(FixedValueTurbulence),
    };

    public override OneOf_PressureInletBCTurbulence? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PressureInletBCTurbulence?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PressureInletBCTurbulence value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
