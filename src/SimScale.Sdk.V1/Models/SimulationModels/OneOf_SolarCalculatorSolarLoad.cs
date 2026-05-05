using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.SimulationModels;

/// <summary>Solar load in solar radiation model. Diffuse solar load affects all walls with a derived heat flux boundary condition externally if the outer surface absorptivity is greater than zero. Direct solar load affects all walls either externally or internally if these are not shadowed by other walls, are non-transparent and have an absorptivity greater than zero. Custom: Define diffusive and directed solar load directly.Fair weather conditions: Define the external and internal solar load by a number of coefficients in the Fair weather condtions model.This assumes the Z-vector to point upwards into the sky.</summary>
[JsonConverter(typeof(OneOf_SolarCalculatorSolarLoadConverter))]
public interface OneOf_SolarCalculatorSolarLoad { }

internal class OneOf_SolarCalculatorSolarLoadConverter : JsonConverter<OneOf_SolarCalculatorSolarLoad>
{
    private static readonly Dictionary<string, Type> Variants = new()
    {
        ["CUSTOM_SOLAR_LOAD"] = typeof(CustomSolarLoad),
        ["FAIR_WEATHER_CONDITIONS"] = typeof(FairWeatherConditions),
    };

    public override OneOf_SolarCalculatorSolarLoad? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (!root.TryGetProperty("type", out var discProp))
            throw new JsonException("Missing discriminator property \"type\"");
        var discValue = discProp.GetString();
        if (discValue == null || !Variants.TryGetValue(discValue, out var variantType))
            throw new JsonException($"Unknown discriminator value \"{discValue}\" for \"type\"");
        return ((OneOf_SolarCalculatorSolarLoad?)JsonSerializer.Deserialize(root.GetRawText(), variantType, options))
            ?? throw new JsonException("Deserialization returned null");
    }

    public override void Write(Utf8JsonWriter writer, OneOf_SolarCalculatorSolarLoad value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
