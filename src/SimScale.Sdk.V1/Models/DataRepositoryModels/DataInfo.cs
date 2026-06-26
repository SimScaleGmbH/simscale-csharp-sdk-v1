using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.DataRepositoryModels;

/// <summary>Information about one data entity. General metadata about the associated piece of business data.</summary>
[JsonConverter(typeof(DataInfoConverter))]
public interface DataInfo { }

internal class DataInfoConverter : JsonConverter<DataInfo>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["externalDataInfo"] = typeof(ExternalDataInfo),
        ["internalDataInfo"] = typeof(InternalDataInfo),
    };

    public override DataInfo? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("data_info_type", out var discProp))
            throw new JsonException("Missing discriminator property \"data_info_type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"data_info_type\"");
        return ((DataInfo?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, DataInfo value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
