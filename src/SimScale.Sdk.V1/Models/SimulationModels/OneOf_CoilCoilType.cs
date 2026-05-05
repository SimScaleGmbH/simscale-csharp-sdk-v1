using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Solid Coil: Is used for coils with usually only a few turns and large-diameter wire which requires explicit meshing. Eddy current effects are significant due to the wire's large diameter where skin depth is about the same or smaller than the wire diameter. Example of a solid coil where each wire is meshed explictly. Stranded Coil: Employed when wires are closely packed, thin, and eddy currents can be neglected. This model represents multiple wires without the need of explicit meshing them, which save significant computational time.Example of a stranded coil where wires are not meshed explicitly.</summary>
[JsonConverter(typeof(OneOf_CoilCoilTypeConverter))]
public interface OneOf_CoilCoilType { }

internal class OneOf_CoilCoilTypeConverter : JsonConverter<OneOf_CoilCoilType>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["STRANDED_COIL"] = typeof(StrandedCoil),
        ["SOLID_COIL"] = typeof(SolidCoil),
        ["LITZ_WIRE_COIL"] = typeof(LitzWireCoil),
    };

    public override OneOf_CoilCoilType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CoilCoilType?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CoilCoilType value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
