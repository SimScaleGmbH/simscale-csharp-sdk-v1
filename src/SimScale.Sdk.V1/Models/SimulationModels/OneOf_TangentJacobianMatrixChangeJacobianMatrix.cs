using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time increment is falling below a given threshold. On the assumption that below a given time increment value the nonlinearities are not evolving within the time step one can strongly save computation time by switching to the elastic matrix.</summary>
[JsonConverter(typeof(OneOf_TangentJacobianMatrixChangeJacobianMatrixConverter))]
public interface OneOf_TangentJacobianMatrixChangeJacobianMatrix { }

internal class OneOf_TangentJacobianMatrixChangeJacobianMatrixConverter : JsonConverter<OneOf_TangentJacobianMatrixChangeJacobianMatrix>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["TRUE"] = typeof(TrueChangeJacobianMatrix),
        ["FALSE"] = typeof(FalseChangeJacobianMatrix),
    };

    public override OneOf_TangentJacobianMatrixChangeJacobianMatrix? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_TangentJacobianMatrixChangeJacobianMatrix?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_TangentJacobianMatrixChangeJacobianMatrix value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
