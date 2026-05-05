using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

/// <summary>Parameters taken into account when some material property values need to be interpolated. When this object is part of a request, the parameters will be taken into account during interpolation, while when it's part of the response, the parameters show the values which were used (if any) during the interpolation. Note that the values used during interpolation might differ from what is requested.</summary>
public class InterpolationParameters : Dictionary<string, JsonElement>
{
}
