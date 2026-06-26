using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

/// <summary>Value interface is the root of the value model type hierarchy. Value models store the computation model of values. The models are defined by the developer, for convenience through a DSL composed of receiver and extension functions and other Kotlin language constructs. When the build runs the definition of the value model, it gets serialized into a JSON representation and that is the artifact of the build. These JSONs are persisted into the database and loaded by the workflow engine for the evaluation of the values. Once values are computed they get stored as data and used by methods or clients to show data to the user. Value models and data models adhere to the same schema defined by the developer in DSSL, just they have a different implementation due to their different roles. Below we define the central repository of value models. These are all part of the framework, available to the workflow engine as well. They provide atomic types and composition mechanisms via containers and the compound value model class. These are in sync with the building blocks in DSSL. User defined types via DSSL schemas are based on the compound value model. The generated value models are available only at build time to the user to define the value computation logic in a type-safe way, meanwhile at runtime in the workflow engine only the compound value model is present. The single value resolution function of this interface is the one used by the workflow engine to execute the value computation. All value models implement this in their own way. The result is always a JSON node, which can be either a single node or an entire tree of nodes behind it. Value model types below are organized into groups based on their parent type, essentially following the hierarchy in a flattened way. The type names - which get into the serialized JSON representation - also follow this structure, where levels are separated with a colon (`:`). By convention names composed of multiple words are presented with snake-case and these rules are followed as a naming convention: * `operation` for operators (both unary and binary, e.g. plus, minus, not...), * `comparison` for comparators (equal, not equal, less than), * `function` for the general case.</summary>
public class Value
{
    [JsonPropertyName("value_model_type")]
    [JsonRequired]
    public required string ValueModelType { get; set; }

}
