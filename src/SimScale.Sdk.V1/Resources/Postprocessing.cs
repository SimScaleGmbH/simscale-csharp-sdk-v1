using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.PostprocessingModels;

namespace SimScale.Sdk.V1.Resources;

public class Postprocessing
{
    private readonly SimScaleClient _client;

    public Postprocessing(SimScaleClient client) => _client = client;

    public List<StateResponse> GetAutomaticStates(
        string projectId,
        Guid resultId
    )
    {
        return _client.Request<List<StateResponse>>(HttpMethod.Get, $"/projects/{projectId}/postprocessing/results/{resultId}/automatic-postprocessor-states");
    }

    public List<StateResponse> GetManualStates(
        string projectId,
        Guid resultId
    )
    {
        return _client.Request<List<StateResponse>>(HttpMethod.Get, $"/projects/{projectId}/postprocessing/results/{resultId}/manual-postprocessor-states");
    }
}
