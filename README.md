# SimScale C# SDK v1

The official C# SDK for the SimScale API v1. Targets .NET 8.0.

> Migrating from v0? See [MIGRATION.md](./MIGRATION.md).

## Requirements

- .NET 8.0 SDK

## Installation

Clone the repository and add a project reference:

```bash
git clone https://github.com/SimScaleGmbH/simscale-csharp-sdk-v1.git
dotnet add reference simscale-csharp-sdk-v1/src/SimScale.Sdk.V1/SimScale.Sdk.V1.csproj
```

## Quick Start

```csharp
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;

using var sdk = new SimScaleSDK();  // reads SIMSCALE_API_KEY from environment

var project = sdk.Projects.CreateProject(new Project
{
    Name = "My Project",
    Description = "Created via SDK",
    MeasurementSystem = "SI",
});
Console.WriteLine($"Created project: {project.ProjectId}");
```

## Configuration

By default, `SimScaleSDK()` reads configuration from environment variables:

| Environment Variable | Description |
|---------------------|-------------|
| `SIMSCALE_API_KEY` | Your SimScale API key (required) |
| `SIMSCALE_API_URL` | API base URL (optional, defaults to `https://api.simscale.com`) |

You can also pass them explicitly:

```csharp
var apiKey = Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
using var sdk = new SimScaleSDK(apiKey: apiKey);
```

### Setting Environment Variables

```sh
export SIMSCALE_API_KEY="your-api-key"
# Optional: override API URL (defaults to https://api.simscale.com)
# export SIMSCALE_API_URL="https://api.simscale.com"
```

On Windows, use `set SIMSCALE_API_KEY=your-api-key` (CMD) or `$env:SIMSCALE_API_KEY="your-api-key"` (PowerShell).

## SDK Structure

All API resources are accessed as properties on the `SimScaleSDK` object:

```csharp
sdk.Projects            // Create, get, update, copy projects
sdk.CadImports          // Import CAD files
sdk.Cads                // Query CAD topology and entities
sdk.MeshOperations      // Create and run mesh operations
sdk.Meshes              // Retrieve mesh information
sdk.Simulations         // Simulation setup and configuration
sdk.SimulationRuns      // Start, monitor, and retrieve simulation runs
sdk.Materials           // Browse and retrieve materials
sdk.Export              // Export simulation results
sdk.Reports             // Create and download reports
sdk.Postprocessing      // Post-processing operations
sdk.Storage             // Create storage for file uploads
sdk.TableImports        // Import table data
```

The SDK implements `IDisposable` -- use a `using` statement to ensure proper cleanup.

## Helper Methods

### Upload

Create a storage entry and upload a file in one call:

```csharp
var storage = sdk.Upload("model.stl");
Console.WriteLine($"Storage ID: {storage.StorageId}");
```

### Download

Download a file from a URL to a local path:

```csharp
sdk.Download(export.Url, "result.csv");
```

### WaitUntilDone

Generic polling helper that waits for an operation to complete. Raises `SimScaleOperationError` on failure:

```csharp
var meshOp = sdk.WaitUntilDone(
    () => sdk.MeshOperations.GetMeshOperation(projectId, meshOpId),
    r => r.Status);
```

Parameters:
- `poll` -- function that fetches the current state
- `getStatus` -- function that extracts the status string from the result
- `timeoutSeconds` -- maximum time to wait (default: 3600)
- `intervalMs` -- polling interval in milliseconds (default: 30000)
- `raiseOnFailure` -- throw `SimScaleOperationError` on failure (default: true)

### GetMaterial

Look up a material by name from the SimScale material library:

```csharp
var waterData = sdk.GetMaterial("Water");
var customMat = sdk.GetMaterial("Steel", group: "My Custom Group");
```

## Models

Model classes are organized under `SimScale.Sdk.V1.Models`, with domain-specific models in sub-namespaces. Use namespace aliases to keep code concise and avoid ambiguity between namespaces that share type names:

```csharp
using SimScale.Sdk.V1.Models;                              // Core API models (Project, SimulationSpec, etc.)
using Sim  = SimScale.Sdk.V1.Models.SimulationModels;       // Simulation setup models
using Mesh = SimScale.Sdk.V1.Models.MeshingModels;          // Meshing models
using Geo  = SimScale.Sdk.V1.Models.GeometryPrimitiveModels; // Geometry primitives
using Rpt  = SimScale.Sdk.V1.Models.ReportingModels;        // Reporting models
using Mat  = SimScale.Sdk.V1.Models.MaterialModels;         // Material models
using Cad  = SimScale.Sdk.V1.Models.CadModels;              // CAD models
using Pp   = SimScale.Sdk.V1.Models.PostprocessingModels;   // Post-processing models
```

Then use the aliases when constructing models:

```csharp
var model = new Sim.Incompressible
{
    TurbulenceModel = "KOMEGASST",
    Materials = new Sim.IncompressibleFluidMaterials(),
    // ...
};
```

### Pagination

Methods that return lists return a `PaginatedResponse<T>` with one page of results:

```csharp
var result = sdk.Projects.GetProjects(limit: 10, page: 1);
Console.WriteLine($"Total projects: {result.Total}");  // total across all pages
foreach (var project in result.Embedded)               // items on this page
    Console.WriteLine(project.Name);
```

To iterate all pages, increment `page` until all items are retrieved.

## Error Handling

### SimScaleAPIError

API errors throw `SimScaleAPIError` with user-friendly formatting:

```csharp
try
{
    sdk.Projects.GetProject("nonexistent-id");
}
catch (SimScaleAPIError e)
{
    Console.WriteLine(e.Message);  // formatted: status, code, message, entries
}
```

### SimScaleOperationError

Thrown by `WaitUntilDone` when an operation fails:

```csharp
try
{
    var run = sdk.WaitUntilDone(
        () => sdk.SimulationRuns.GetSimulationRun(projectId, simulationId, runId),
        r => r.Status);
}
catch (SimScaleOperationError e)
{
    Console.WriteLine(e.Message);  // status, failure reason, entries
}
```

### CAD Import

CAD import uses typed model classes for location and options:

```csharp
var cadImport = sdk.CadImports.ImportCad(projectId, new CadImportRequest
{
    Name = "My CAD",
    Location = new CadImportRequestLocation { StorageId = storage.StorageId! },
    Format = "PARASOLID",
    InputUnit = CadUnit.M,
    Options = new CadImportRequestOptions
    {
        FacetSplit = false,
        Sewing = false,
        Improve = true,
    },
});
```

## SDK Code Generator

Generate C# SDK code from an existing simulation or mesh operation setup. This fetches
the spec from the SimScale API and outputs C# object-initializer code for the simulation
or meshing model (the `Model` property of `SimulationSpec` / `MeshOperation`). Wrapper
fields like `CadId`, `StateId`, and `Parameters` are not included — provide those
separately when creating the resource.

### CLI

```bash
cd src/SimScale.Sdk.V1.SdkCode

# From a simulation
dotnet run -- --project PID --simulation SID

# From a simulation run
dotnet run -- --project PID --simulation SID --simulation-run RID

# From a mesh operation
dotnet run -- --project PID --mesh-operation MID
```

### Library

```csharp
using SimScale.Sdk.V1;

var code = SdkCode.GenerateSdkCode(
    projectId: "project-id",
    simulationId: Guid.Parse("simulation-id"));
Console.WriteLine(code);
```

### Output

The generated code uses namespace aliases and object initializer syntax:

```csharp
using Sim = SimScale.Sdk.V1.Models.SimulationModels;

new Sim.Incompressible
{
    TurbulenceModel = "KOMEGASST",
    Algorithm = "SIMPLE",
    Model = new Sim.FluidModel(),
    // ...
}
```

## Examples

The `examples/` folder contains complete, runnable projects:

| Example | Description |
|---------|-------------|
| `IncompressibleExample` | End-to-end CFD workflow: project creation, CAD upload/import, simulation setup, meshing, run execution, result export, and report generation |
| `IncompressibleLbmExample` | Incompressible LBM (Pacefish): table imports (CSV inlet profiles, probe points), flow domain boundaries, geometry primitives, mesh refinement regions, transient/statistical/snapshot result controls, forces/moments tracking, and screenshot report |
| `PedestrianWindComfortExample` | Pedestrian Wind Comfort (PWC): wind rose data, geographical location, region of interest, comfort surfaces, Wind API integration, and additional wind data for reusing directional results |
| `FoldersAndSpacesExample` | Space and folder management: creation, listing, moving, and deletion |

### Running Examples

```bash
cd examples/IncompressibleExample
dotnet run
```

