using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Specify the subspace used by the eigensolver. This setting should only be changed if the errors during the solution procedure occur that recommend to change it. In general, the more frequencies are computed, the larger the subspace should be. Automatic: The solver selects an appropriate subspace itself based on the model and other inputs.Dimension: Directly specify the subspace dimension. This should be only done after checking the error log, which gives hints on selecting this setting.Coefficient: Multiplier for setting the subspace dimension proportional to the number of computed frequencies</summary>
[JsonConverter(typeof(OneOf_BatheWilsonSubspaceSettingsConverter))]
public interface OneOf_BatheWilsonSubspaceSettings { }

internal class OneOf_BatheWilsonSubspaceSettingsConverter : JsonConverter<OneOf_BatheWilsonSubspaceSettings>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["AUTOMATIC"] = typeof(AutomaticSubspaceSettings),
        ["SUBSPACE_DIMENSION"] = typeof(SubspaceDimension),
        ["SUBSPACE_COEFFICIENT"] = typeof(SubspaceCoefficient),
    };

    public override OneOf_BatheWilsonSubspaceSettings? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_BatheWilsonSubspaceSettings?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_BatheWilsonSubspaceSettings value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
