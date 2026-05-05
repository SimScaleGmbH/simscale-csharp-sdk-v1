using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_HConstThermoEquationOfStateConverter))]
public interface OneOf_HConstThermoEquationOfState { }

internal class OneOf_HConstThermoEquationOfStateConverter : JsonConverter<OneOf_HConstThermoEquationOfState>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PERFECT_GAS"] = typeof(PerfectGasEquationOfState),
        ["REAL_GAS"] = typeof(RealGasEquationOfState),
        ["RHO_CONST"] = typeof(RhoConstEquationOfState),
        ["PERFECT_FLUID"] = typeof(PerfectFluidEquationOfState),
        ["INCOMPRESSIBLE_PERFECT_GAS"] = typeof(IncompressiblePerfectGasEquationOfState),
        ["ADIABATIC_PERFECT_FLUID"] = typeof(AdiabaticPerfectFluidEquationOfState),
        ["PENG_ROBINSON_GAS"] = typeof(PengRobinsonGasEquationOfState),
    };

    public override OneOf_HConstThermoEquationOfState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_HConstThermoEquationOfState?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_HConstThermoEquationOfState value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
