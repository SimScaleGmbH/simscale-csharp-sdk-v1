using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.ParametricModels;

public class Parameters : Dictionary<string, OneOf_Parameters>
{
}
