using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>By selecting the Prony series, you enable a viscoelastic network that models time-dependent behavior such as stress relaxation and creep. This model uses a series of decay constants (relaxation times) to define how the material's internal stresses dissipate over time under sustained loading.</summary>
[JsonConverter(typeof(OneOf_ViscoelasticNetworkCreepModelViscoelasticNetworkConverter))]
public interface OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork { }

internal class OneOf_ViscoelasticNetworkCreepModelViscoelasticNetworkConverter : JsonConverter<OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["PRONY_SERIES"] = typeof(PronySeries),
        ["OFF"] = typeof(NoCreep),
    };

    public override OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_ViscoelasticNetworkCreepModelViscoelasticNetwork value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
