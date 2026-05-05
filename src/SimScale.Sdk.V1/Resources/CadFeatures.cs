using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.CadModels;

namespace SimScale.Sdk.V1.Resources;

public class CadFeatures
{
    private readonly SimScaleClient _client;

    public CadFeatures(SimScaleClient client) => _client = client;

    /// <summary>Add a feature to the CAD Adding a CAD feature that involves complex computation might take some time to complete. Please refer to the following steps to start a CAD feature generation and check its progress: 1. Trigger the CAD feature generation via `POST /cads/{cadId}/states/{cadStateId}/features` 2. Monitor progress via `GET /cads/{cadId}/features/progress`</summary>
    public CadFeatureResponse AddCadFeature(
        Guid cadId,
        Guid cadStateId,
        CadFeatureRequest body
    )
    {
        return _client.Request<CadFeatureResponse>(HttpMethod.Post, $"/cads/{cadId}/states/{cadStateId}/features", body);
    }

    /// <summary>Get the CAD feature event log</summary>
    public EventLogResponse GetCadFeatureEventLog(
        Guid cadId,
        Guid cadStateId,
        Guid cadFeatureId
    )
    {
        return _client.Request<EventLogResponse>(HttpMethod.Get, $"/cads/{cadId}/states/{cadStateId}/features/{cadFeatureId}/eventlog");
    }

    /// <summary>Monitor CAD feature generation progress Monitor CAD feature generation progress for long-running processes.</summary>
    public CadFeatureResponse GetCadFeaturesProgress(
        Guid cadId
    )
    {
        return _client.Request<CadFeatureResponse>(HttpMethod.Get, $"/cads/{cadId}/features/progress");
    }
}
