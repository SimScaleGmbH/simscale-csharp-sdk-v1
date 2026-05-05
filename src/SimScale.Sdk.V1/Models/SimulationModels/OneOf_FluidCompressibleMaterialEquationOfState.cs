using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_FluidCompressibleMaterialEquationOfStateConverter))]
public interface OneOf_FluidCompressibleMaterialEquationOfState { }

internal class OneOf_FluidCompressibleMaterialEquationOfStateConverter : JsonConverter<OneOf_FluidCompressibleMaterialEquationOfState>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PERFECT_GAS"] = typeof(PerfectGasEquationOfState),
        ["RHO_CONST"] = typeof(RhoConstEquationOfState),
    };

    public override OneOf_FluidCompressibleMaterialEquationOfState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_FluidCompressibleMaterialEquationOfState?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_FluidCompressibleMaterialEquationOfState value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
