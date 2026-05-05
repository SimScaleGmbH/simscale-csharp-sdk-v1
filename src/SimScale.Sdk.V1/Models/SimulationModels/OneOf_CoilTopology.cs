using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Open Coil: This coil topology has an entry port and an exit port.Example of an open coil with an entry (blue) and exit (red) port. Note that an entry port and exit port should lie on an outer boundary with Magnetic flux tangential boundaries. Closed Coil: This coil topology is a self-contained loop with no entry or exit ports. An internal port is used to specify the current flow surface within the coil. Example of a closed coil with an internal port (blue).</summary>
[JsonConverter(typeof(OneOf_CoilTopologyConverter))]
public interface OneOf_CoilTopology { }

internal class OneOf_CoilTopologyConverter : JsonConverter<OneOf_CoilTopology>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["OPEN_COIL"] = typeof(OpenCoil),
        ["CLOSED_COIL"] = typeof(ClosedCoil),
    };

    public override OneOf_CoilTopology? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_CoilTopology?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_CoilTopology value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
