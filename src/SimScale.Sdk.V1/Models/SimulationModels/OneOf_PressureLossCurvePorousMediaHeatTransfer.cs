using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>The heat transfer modelling inside the porous media matrix:Fluid only: This model uses exclusively the fluid thermal properties in the porous media region. Effective conductivity: This model takes the effective thermal conductivity for the fluid-solid porous matrix as a constant value or a tabulated velocity function.</summary>
[JsonConverter(typeof(OneOf_PressureLossCurvePorousMediaHeatTransferConverter))]
public interface OneOf_PressureLossCurvePorousMediaHeatTransfer { }

internal class OneOf_PressureLossCurvePorousMediaHeatTransferConverter : JsonConverter<OneOf_PressureLossCurvePorousMediaHeatTransfer>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["FLUID_ONLY_HEAT_TRANSFER"] = typeof(FluidOnlyHeatTransfer),
        ["EFFECTIVE_CONDUCTIVITY_HEAT_TRANSFER"] = typeof(EffectiveConductivityHeatTransfer),
    };

    public override OneOf_PressureLossCurvePorousMediaHeatTransfer? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_PressureLossCurvePorousMediaHeatTransfer?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_PressureLossCurvePorousMediaHeatTransfer value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
