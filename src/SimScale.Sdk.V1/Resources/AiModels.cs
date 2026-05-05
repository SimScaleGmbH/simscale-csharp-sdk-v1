using System.Text.Json;
using SimScale.Sdk.V1.Models;

namespace SimScale.Sdk.V1.Resources;

public class AiModels
{
    private readonly SimScaleClient _client;

    public AiModels(SimScaleClient client) => _client = client;

    /// <summary>Generate an AI prediction for a simulation based on an AI model</summary>
    public CreateAiPredictionResponse CreatePrediction(
        CreateAiPredictionRequest body
    )
    {
        return _client.Request<CreateAiPredictionResponse>(HttpMethod.Post, $"/ai/predict", body);
    }

    /// <summary>Get specific AI model belonging to the user</summary>
    public AiUserModel GetAiModel(
        Guid aiModelId
    )
    {
        return _client.Request<AiUserModel>(HttpMethod.Get, $"/ai/models/{aiModelId}");
    }

    /// <summary>Get all AI models belonging to the user</summary>
    public List<AiUserModel> GetAiModels()
    {
        return _client.Request<List<AiUserModel>>(HttpMethod.Get, $"/ai/models");
    }

    /// <summary>Get all AI model belonging to the user that can be used to run a specific simulation</summary>
    public List<AvailableAiModel> GetAvailableAiModel(
        Guid? simulationId = null,
        string? projectId = null
    )
    {
        return _client.Request<List<AvailableAiModel>>(HttpMethod.Get, $"/ai/available-models",
            queryParams: new Dictionary<string, object?> { ["simulationId"] = simulationId, ["projectId"] = projectId });
    }
}
