using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

[JsonConverter(typeof(OneOf_SolidNumericsEigenSolverConverter))]
public interface OneOf_SolidNumericsEigenSolver { }

internal class OneOf_SolidNumericsEigenSolverConverter : JsonConverter<OneOf_SolidNumericsEigenSolver>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["SORENSEN"] = typeof(IRAMSorensen),
        ["TRI_DIAG"] = typeof(Lanczos),
        ["JACOBI"] = typeof(BatheWilson),
        ["QZ"] = typeof(QZ),
    };

    public override OneOf_SolidNumericsEigenSolver? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolidNumericsEigenSolver?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolidNumericsEigenSolver value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
