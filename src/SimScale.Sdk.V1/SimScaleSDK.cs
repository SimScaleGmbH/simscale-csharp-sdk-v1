using SimScale.Sdk.V1.Resources;

namespace SimScale.Sdk.V1;

public partial class SimScaleSDK : IDisposable
{
    private readonly SimScaleClient _client;

    public AiModels AiModels { get; }
    public CadFeatures CadFeatures { get; }
    public CadImports CadImports { get; }
    public Cads Cads { get; }
    public Export Export { get; }
    public Folders Folders { get; }
    public Materials Materials { get; }
    public MeshOperations MeshOperations { get; }
    public Meshes Meshes { get; }
    public Postprocessing Postprocessing { get; }
    public ProjectPermissions ProjectPermissions { get; }
    public Projects Projects { get; }
    public Reports Reports { get; }
    public SimulationRuns SimulationRuns { get; }
    public Simulations Simulations { get; }
    public SpacePermissions SpacePermissions { get; }
    public Spaces Spaces { get; }
    public Storage Storage { get; }
    public TableImports TableImports { get; }
    public Users Users { get; }
    public Wind Wind { get; }

    public SimScaleSDK(string? apiKey = null, string? serverUrl = null)
    {
        var resolvedKey = apiKey ?? Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
        if (string.IsNullOrEmpty(resolvedKey))
            throw new InvalidOperationException("api_key must be provided or SIMSCALE_API_KEY environment variable must be set");
        var resolvedUrl = (serverUrl ?? Environment.GetEnvironmentVariable("SIMSCALE_API_URL") ?? "https://api.simscale.com")
            .TrimEnd('/') + "/v1";
        _client = new SimScaleClient(resolvedKey, resolvedUrl);
        AiModels = new AiModels(_client);
        CadFeatures = new CadFeatures(_client);
        CadImports = new CadImports(_client);
        Cads = new Cads(_client);
        Export = new Export(_client);
        Folders = new Folders(_client);
        Materials = new Materials(_client);
        MeshOperations = new MeshOperations(_client);
        Meshes = new Meshes(_client);
        Postprocessing = new Postprocessing(_client);
        ProjectPermissions = new ProjectPermissions(_client);
        Projects = new Projects(_client);
        Reports = new Reports(_client);
        SimulationRuns = new SimulationRuns(_client);
        Simulations = new Simulations(_client);
        SpacePermissions = new SpacePermissions(_client);
        Spaces = new Spaces(_client);
        Storage = new Storage(_client);
        TableImports = new TableImports(_client);
        Users = new Users(_client);
        Wind = new Wind(_client);
    }

    public SimScaleClient Client => _client;

    public void Dispose() => _client.Dispose();
}
