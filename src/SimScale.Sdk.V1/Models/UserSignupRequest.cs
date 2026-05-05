using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimScale.Sdk.V1.Models;

public class UserSignupRequest
{
    [JsonPropertyName("email")]
    [JsonRequired]
    public required string Email { get; set; }

    [JsonPropertyName("firstname")]
    [JsonRequired]
    public required string Firstname { get; set; }

    [JsonPropertyName("lastname")]
    [JsonRequired]
    public required string Lastname { get; set; }

    /// <summary>I agree to the End User License Terms and the Privacy Policy</summary>
    [JsonPropertyName("consentTermsConditionsPrivacy")]
    [JsonRequired]
    public required bool ConsentTermsConditionsPrivacy { get; set; }

    /// <summary>SimScale may occasionally contact you via e-mail to present you with similar goods and services of SimScale unless yo...</summary>
    [JsonPropertyName("consentToBeContacted")]
    [JsonRequired]
    public required bool ConsentToBeContacted { get; set; }

}
