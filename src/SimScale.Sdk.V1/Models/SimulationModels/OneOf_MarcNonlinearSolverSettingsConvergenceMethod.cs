using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Selects the physical quantity used to determine if the simulation has converged. The force residual or the displacement changes must satisfy their respective tolerances.Displacement: Monitors the change in nodal displacements between iterations; convergence is achieved when displacements stabilize.Force: Monitors the force residuals; convergence is achieved when the out-of-balance force residuals become small enough relative to the applied loads.Both: Both the force residual and displacement changes must satisfy their respective tolerances.</summary>
[JsonConverter(typeof(OneOf_MarcNonlinearSolverSettingsConvergenceMethodConverter))]
public interface OneOf_MarcNonlinearSolverSettingsConvergenceMethod { }

internal class OneOf_MarcNonlinearSolverSettingsConvergenceMethodConverter : JsonConverter<OneOf_MarcNonlinearSolverSettingsConvergenceMethod>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["RESIDUALS"] = typeof(ResidualsConvergenceMethod),
        ["DISPLACEMENTS"] = typeof(DisplacementsConvergenceMethod),
        ["STRAIN_ENERGY"] = typeof(StrainEnergyConvergenceMethod),
        ["RESIDUALS_OR_DISPLACEMENTS"] = typeof(ResidualsOrDisplacementsConvergenceMethod),
    };

    public override OneOf_MarcNonlinearSolverSettingsConvergenceMethod? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_MarcNonlinearSolverSettingsConvergenceMethod?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_MarcNonlinearSolverSettingsConvergenceMethod value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
