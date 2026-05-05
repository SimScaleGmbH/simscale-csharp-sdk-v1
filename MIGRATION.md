# Migrating from v0 SDK

This section covers migrating from the v0 C# SDK (`SimScale.Sdk`) to the v1 SDK (`SimScale.Sdk.V1`).

## 1. Initialization

```csharp
// v0
var configuration = new Configuration { BasePath = apiUrl + "/v0" };
configuration.ApiKey.Add("X-API-KEY", apiKey);
var projectsApi = new ProjectsApi(configuration);
var simulationsApi = new SimulationsApi(configuration);

// v1
using var sdk = new SimScaleSDK();
```

## 2. Namespaces & Imports

v0 imported all model classes from a single flat namespace. v1 organizes models into domain-specific sub-namespaces:

```csharp
// v0
using SimScale.Sdk.Api;
using SimScale.Sdk.Model;  // all models in one namespace

// v1
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;                              // core API models (Project, SimulationSpec, etc.)
using Sim  = SimScale.Sdk.V1.Models.SimulationModels;       // simulation setup models
using Mesh = SimScale.Sdk.V1.Models.MeshingModels;          // meshing models
using Rpt  = SimScale.Sdk.V1.Models.ReportingModels;        // reporting models
using Geo  = SimScale.Sdk.V1.Models.GeometryPrimitiveModels; // geometry primitives
```

Then use `new Project { ... }` for core models and `new Sim.WindComfort { ... }`, `new Mesh.SimmetrixMeshingFluid { ... }`, etc. for domain models. Available sub-namespaces: `SimulationModels`, `MeshingModels`, `ReportingModels`, `GeometryPrimitiveModels`, `MaterialModels`, `CadModels`, `PostprocessingModels`, `ParametricModels`.

## 3. API Calls

```csharp
// v0
projectsApi.CreateProject(project);
simulationsApi.CheckSimulationSetup(projectId, simulationId);

// v1
sdk.Projects.CreateProject(project);
sdk.Simulations.CheckSimulationSetup(projectId, simulationId);
```

## 4. Geometry -> CAD Rename

The v1 API renamed geometry-related endpoints to CAD:

```csharp
// v0
geometryImportsApi.ImportGeometry(projectId, geometryImportRequest);
// SimulationSpec: GeometryId = gid

// v1
sdk.CadImports.ImportCad(projectId, cadImportRequest);
// SimulationSpec: CadId = cadId, StateId = cadStateId
```

In v1, a CAD import returns both `CadId` and `CadStateId`. Both must be passed to `SimulationSpec` and `MeshOperation` — `CadId` identifies the CAD model, `StateId` identifies its specific version/state.

## 5. CAD Import Request Models

The v0 geometry import request classes were renamed to CAD (not removed):

```csharp
// v0
new GeometryImportRequestLocation(storageId)

// v1
new CadImportRequestLocation { StorageId = storageId }
```

## 6. Model Class Renames

The v1 SDK uses schema names directly from the OpenAPI spec, which include underscores that v0 stripped:

| v0 | v1 |
|----|-----|
| `DimensionalLength` | `Dimensional_Length` |
| `DimensionalAngle` | `Dimensional_Angle` |
| `DimensionalPressure` | `Dimensional_Pressure` |
| `DimensionalTime` | `Dimensional_Time` |
| `DimensionalVectorLength` | `DimensionalVector_Length` |
| `DimensionalVector2dLength` | `DimensionalVector2d_Length` |
| `DimensionalVectorFunctionSpeed` | `DimensionalVectorFunction_Speed` |
| `DimensionalFunctionPressure` | `DimensionalFunction_Pressure` |
| `DimensionalFunctionSpeed` | `DimensionalFunction_Speed` |
| `DimensionalFunctionDimensionless` | `DimensionalFunction_Dimensionless` |
| `DimensionalFunctionSpecificTurbulenceDissipationRate` | `DimensionalFunction_SpecificTurbulenceDissipationRate` |
| `DimensionalVectorAngle` | `DimensionalVector_Angle` |

General pattern: where the OpenAPI schema name contains an underscore (e.g., `Dimensional_Pressure`), v0 removed it (`DimensionalPressure`) while v1 preserves it. This applies to all `Dimensional*` classes.

## 7. Enum Classes → String Literals

v0 generated enum classes; v1 uses string literals (matching the API values):

| v0 | v1 |
|----|-----|
| `ProjectionType.Orthogonal` | `"ORTHOGONAL"` |
| `RenderMode.Surfaces` | `"SURFACES"` |

## 8. Pagination

```csharp
// v0: result.Meta.Total
// v1: result.Total
```

## 9. File Upload & Download

```csharp
// v0
apiClient.RestClient.Put(storage.Url, body, headers);

// v1
var storage = sdk.Upload("model.stl");
sdk.Download(export.Url, "result.csv");
```

## 10. Table Imports

Table import follows the same upload-then-import pattern as CAD imports. The model classes (`TableImportRequest`, `TableImportRequestLocation`) are in the root `Models` namespace:

```csharp
// v0
var tableStorage = storageApi.CreateStorage();
apiClient.RestClient.Put(tableStorage.Url, body, headers);
var tableImport = tableImportsApi.ImportTable(projectId,
    new TableImportRequest(new TableImportRequestLocation(tableStorage.StorageId)));
var tableId = tableImport.TableId;

// v1
var tableStorage = sdk.Upload("data.csv");
var tableImport = sdk.TableImports.ImportTable(projectId, new TableImportRequest
{
    Location = new TableImportRequestLocation { StorageId = tableStorage.StorageId! },
});
var tableId = tableImport.TableId;
```

## 11. Geometry Primitives

Geometry primitive classes (`RotatableCartesianBox`, `LocalCartesianBox`, `Point`, etc.) are in the `GeometryPrimitiveModels` sub-namespace:

```csharp
using Geo = SimScale.Sdk.V1.Models.GeometryPrimitiveModels;

// v0
var box = new RotatableCartesianBox
{
    Name = "External Flow Domain",
    Min = new DimensionalVectorLength { Value = new DecimalVector { X = -350, Y = -100, Z = 0 }, Unit = "m" },
    ...
};
var uuid = simulationsApi.CreateGeometryPrimitive(projectId, box).GeometryPrimitiveId;

// v1
var box = sdk.Simulations.CreateGeometryPrimitive(projectId, new Geo.RotatableCartesianBox
{
    Name = "External Flow Domain",
    Min = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = -350, Y = -100, Z = 0 },
        Unit = "m",
    },
    ...
});
var uuid = box.GeometryPrimitiveId;
```

Note: `DimensionalVector_Length`, `DecimalVector`, and `DimensionalVector_Angle` exist in both `SimulationModels` and `GeometryPrimitiveModels`. Use the namespace alias that matches the context (`Geo.` for geometry primitives, `Sim.` for simulation models).

## 12. Error Handling

```csharp
// v0: catch (ApiException e) { e.ErrorCode; e.ErrorContent; }
// v1: catch (SimScaleAPIError e) { e.StatusCode; e.ResponseBody; }
```

v1 also adds `SimScaleOperationError`, raised automatically by `sdk.WaitUntilDone()` when an operation finishes with a failure status. You can also throw it manually for setup check failures:

```csharp
var check = sdk.Simulations.CheckSimulationSetup(projectId, simulationId);
if (check.Entries?.Any(e => e.Severity == "ERROR") == true)
    throw new SimScaleOperationError(check, "Simulation setup check failed");
```

## 13. Result Downloads via Export API

In v0, some simulation run results (e.g., `STATISTICAL_SURFACE_SOLUTION`) had a `Download.Url` property for direct download. In v1, all result downloads go through the Export API:

```csharp
// v0: direct download from result
var result = results.Embedded[0];
var response = apiClient.RestClient.Get(result.Download.Url, headers);

// v1: create an export, wait for it, then download
var result = results.Embedded[0];
var exportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = result.ResultId,
    Format = "VTK",
});
var exportResp = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, exportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
sdk.Download(exportResp.Url!, "result.zip");
```

## 14. Polling Loops → `WaitUntilDone`

v0 examples used manual `while` loops with `Thread.Sleep()` and `DateTime` for timeout tracking. v1 replaces all of these with `sdk.WaitUntilDone()`:

```csharp
// v0
var start = DateTime.UtcNow;
while (geometryImport.Status != "FINISHED" && geometryImport.Status != "FAILED")
{
    if ((DateTime.UtcNow - start).TotalSeconds > 900) throw new TimeoutException();
    Thread.Sleep(10_000);
    geometryImport = geometryImportsApi.GetGeometryImport(projectId, geometryImportId);
}

// v1
cadImport = sdk.WaitUntilDone(
    () => sdk.CadImports.GetImportedCad(projectId, cadId),
    r => r.Status, timeoutSeconds: 900, intervalMs: 10_000);
```

This applies to CAD imports, mesh operations, simulation runs, exports, and reports. The method throws `SimScaleOperationError` on failure and `TimeoutException` on timeout.

## 15. Removed Boilerplate

- No more per-resource API class instantiation
- No more `Configuration` / `ApiClient` setup
- No external NuGet dependencies (v0 used Newtonsoft.Json, RestSharp)

## Quick Migration Checklist

1. [ ] Replace `Configuration` + `ApiClient` + `XxxApi(...)` with `new SimScaleSDK()`
2. [ ] Update namespaces: `SimScale.Sdk` -> `SimScale.Sdk.V1` (use sub-namespace aliases like `Sim`, `Mesh`, `Rpt`)
3. [ ] Replace `xxxApi.Method(...)` with `sdk.Resource.Method(...)`
4. [ ] Rename `Geometry` -> `Cad` (imports, API calls, model fields)
5. [ ] Add `StateId` to `SimulationSpec` and `MeshOperation` (from CAD import's `CadStateId`)
6. [ ] Update model class names with underscores (e.g., `DimensionalPressure` -> `Dimensional_Pressure`)
7. [ ] Rename `GeometryImportRequest*` classes to `CadImportRequest*`
8. [ ] Replace enum classes with string literals (e.g., `ProjectionType.Orthogonal` -> `"ORTHOGONAL"`)
9. [ ] Update pagination: `.Meta.Total` -> `.Total`
10. [ ] Replace manual upload/download with `sdk.Upload()` / `sdk.Download()`
11. [ ] Replace `tableImportsApi` with `sdk.TableImports` and use `sdk.Upload()` for table files
12. [ ] Use `GeometryPrimitiveModels` sub-namespace (`Geo.`) for geometry primitive models (`RotatableCartesianBox`, `LocalCartesianBox`, `Point`, etc.)
13. [ ] Replace `ApiException` with `SimScaleAPIError`
14. [ ] Replace direct `result.Download.Url` with Export API (`sdk.Export.CreateExport()` + `sdk.Download()`)
15. [ ] Replace manual polling loops with `sdk.WaitUntilDone()`
16. [ ] Remove NuGet dependencies on Newtonsoft.Json and RestSharp
