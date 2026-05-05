using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Choose the preconditioner for the iterative solver:incomplete LDLT performs an incomplete Cholesky decomposition.MUMPS LDLT performs a complete Cholesky decomposition in single precision via the MUMPS package.Jacobi is a standard diagonal preconditioner.SOR uses the method of Successive Over-Relaxation.</summary>
[JsonConverter(typeof(OneOf_AdvancedPETSCSettingsPreconditionerConverter))]
public interface OneOf_AdvancedPETSCSettingsPreconditioner { }

internal class OneOf_AdvancedPETSCSettingsPreconditionerConverter : JsonConverter<OneOf_AdvancedPETSCSettingsPreconditioner>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["MUMPS_LDLT"] = typeof(MUMPSPreconditoner),
        ["INCOMPLETE_LDLT_V33"] = typeof(IncompletePreconditionerV33),
        ["JACOBI"] = typeof(JacobiPreconditioner),
        ["SOR"] = typeof(SorPreconditioner),
        ["INACTIVE"] = typeof(InactivePreconditioner),
    };

    public override OneOf_AdvancedPETSCSettingsPreconditioner? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_AdvancedPETSCSettingsPreconditioner?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_AdvancedPETSCSettingsPreconditioner value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
