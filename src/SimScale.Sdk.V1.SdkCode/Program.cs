using SimScale.Sdk.V1;

var projectId = (string?)null;
Guid? simulationId = null;
Guid? simulationRunId = null;
Guid? meshOperationId = null;

for (var i = 0; i < args.Length; i++)
{
    switch (args[i])
    {
        case "--project":
            projectId = args[++i];
            break;
        case "--simulation":
            simulationId = Guid.Parse(args[++i]);
            break;
        case "--simulation-run":
            simulationRunId = Guid.Parse(args[++i]);
            break;
        case "--mesh-operation":
            meshOperationId = Guid.Parse(args[++i]);
            break;
        case "--help" or "-h":
            PrintUsage();
            return;
        default:
            Fail($"Unknown argument: {args[i]}");
            break;
    }
}

if (string.IsNullOrEmpty(projectId))
    Fail("--project is required");
if (simulationId == null && meshOperationId == null)
    Fail("--simulation or --mesh-operation is required");
if (simulationId != null && meshOperationId != null)
    Fail("--simulation and --mesh-operation are mutually exclusive");
if (simulationRunId != null && simulationId == null)
    Fail("--simulation-run requires --simulation");

try
{
    var code = SdkCode.GenerateSdkCode(projectId!, simulationId, simulationRunId, meshOperationId);
    Console.Write(code);
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error: {ex.Message}");
    Environment.Exit(1);
}

static void Fail(string message)
{
    Console.Error.WriteLine($"Error: {message}");
    PrintUsage();
    Environment.Exit(1);
}

static void PrintUsage()
{
    Console.Error.WriteLine("""
        Generate C# SDK v1 code from a simulation/meshing spec.

        Usage:
          dotnet run -- --project PID --simulation SID
          dotnet run -- --project PID --simulation SID --simulation-run RID
          dotnet run -- --project PID --mesh-operation MID

        Options:
          --project          SimScale project ID (required)
          --simulation       SimScale simulation ID
          --simulation-run   SimScale simulation run ID
          --mesh-operation   SimScale mesh operation ID
          --help, -h         Show this help message

        Uses the same environment variables as the SDK:
          SIMSCALE_API_KEY   API key (required)
          SIMSCALE_API_URL   API base URL (default: https://api.simscale.com)
        """);
}
