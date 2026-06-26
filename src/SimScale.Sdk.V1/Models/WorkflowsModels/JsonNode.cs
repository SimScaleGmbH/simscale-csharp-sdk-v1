using System.Text.Json;
using System.Text.Json.Serialization;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Models.WorkflowsModels;

public class JsonNode
{
    [JsonPropertyName("array")]
    public bool? Array { get; set; }

    [JsonPropertyName("bigDecimal")]
    public bool? BigDecimal { get; set; }

    [JsonPropertyName("bigInteger")]
    public bool? BigInteger { get; set; }

    [JsonPropertyName("binary")]
    public bool? Binary { get; set; }

    [JsonPropertyName("boolean")]
    public bool? Boolean { get; set; }

    [JsonPropertyName("container")]
    public bool? Container { get; set; }

    [JsonPropertyName("double")]
    public bool? @Double { get; set; }

    [JsonPropertyName("embeddedValue")]
    public bool? EmbeddedValue { get; set; }

    [JsonPropertyName("empty")]
    public bool? Empty { get; set; }

    [JsonPropertyName("float")]
    public bool? @Float { get; set; }

    [JsonPropertyName("floatingPointNumber")]
    public bool? FloatingPointNumber { get; set; }

    [JsonPropertyName("int")]
    public bool? @Int { get; set; }

    [JsonPropertyName("integralNumber")]
    public bool? IntegralNumber { get; set; }

    [JsonPropertyName("long")]
    public bool? @Long { get; set; }

    [JsonPropertyName("missingNode")]
    public bool? MissingNode { get; set; }

    [JsonPropertyName("nodeType")]
    public string? NodeType { get; set; }

    [JsonPropertyName("null")]
    public bool? @Null { get; set; }

    [JsonPropertyName("number")]
    public bool? Number { get; set; }

    [JsonPropertyName("object")]
    public bool? @Object { get; set; }

    [JsonPropertyName("pojo")]
    public bool? Pojo { get; set; }

    [JsonPropertyName("short")]
    public bool? @Short { get; set; }

    [JsonPropertyName("string")]
    public bool? @String { get; set; }

    [JsonPropertyName("textual")]
    public bool? Textual { get; set; }

    [JsonPropertyName("valueNode")]
    public bool? ValueNode { get; set; }

}
