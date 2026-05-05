using System.IO.Compression;
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;
using Sim = SimScale.Sdk.V1.Models.SimulationModels;
using Rpt = SimScale.Sdk.V1.Models.ReportingModels;

// Resolve paths relative to the project directory (works with dotnet run from any location)
var exampleDir = Directory.GetCurrentDirectory();

using var sdk = new SimScaleSDK();

// Create project
var project = sdk.Projects.CreateProject(new Project
{
    Name = "Pedestrian Wind Comfort via CSharp SDK",
    Description = "Pedestrian Wind Comfort via CSharp SDK",
    MeasurementSystem = "SI",
});
var projectId = project.ProjectId!;
Console.WriteLine($"projectId: {projectId}");

// Upload and import CAD
var storage = sdk.Upload(Path.Combine(exampleDir, "../fixtures/Cylinder.stl"));
var cadImport = sdk.CadImports.ImportCad(projectId, new CadImportRequest
{
    Name = "Cylinder",
    Location = new CadImportRequestLocation { StorageId = storage.StorageId! },
    Format = "STL",
    InputUnit = CadUnit.M,
    Options = new CadImportRequestOptions
    {
        FacetSplit = false,
        Sewing = false,
        Improve = true,
        OptimizeForLBMSolver = true,
    },
});
var cadId = cadImport.CadId;
cadImport = sdk.WaitUntilDone(
    () => sdk.CadImports.GetImportedCad(projectId, cadId),
    r => r.Status, timeoutSeconds: 900, intervalMs: 10_000);
var cadStateId = cadImport.CadStateId;
Console.WriteLine($"cadId: {cadId}, cadStateId: {cadStateId}");

// The wind data can be user-defined or obtained from the Wind API, as shown in the following two examples:

// 1. User-defined wind data for simulation spec
var windRose = new Sim.WindRose
{
    NumDirections = 4,
    VelocityBuckets =
    [
        new Sim.WindRoseVelocityBucket { From = null, To = 1.234, Fractions = [0.1, 0.1, 0.1, 0.1] },
        new Sim.WindRoseVelocityBucket { From = 1.234, To = 2.345, Fractions = [0.0, 0.1, 0.1, 0.1] },
        new Sim.WindRoseVelocityBucket { From = 2.345, To = 3.456, Fractions = [0.0, 0.0, 0.1, 0.1] },
        new Sim.WindRoseVelocityBucket { From = 3.456, To = null, Fractions = [0.0, 0.0, 0.0, 0.1] },
    ],
    VelocityUnit = "m/s",
    ExposureCategories = ["EC4", "EC4", "EC4", "EC4"],
    WindEngineeringStandard = "EU",
    WindDataSource = "USER_UPLOAD",
    AddSurfaceRoughness = false,
};

// 2. Get wind data from the Wind API for simulation spec
var windRoseResponse = sdk.Wind.GetWindData(latitude: "48.135125", longitude: "11.581981");
windRose = windRoseResponse.WindRose;
windRose.NumDirections = 4;
windRose.ExposureCategories = ["EC4", "EC4", "EC4", "EC4"];
windRose.WindEngineeringStandard = "EU";
windRose.AddSurfaceRoughness = false;

// Create simulation spec
var model = new Sim.WindComfort
{
    RegionOfInterest = new Sim.RegionOfInterest
    {
        DiscRadius = new Sim.Dimensional_Length { Value = 100, Unit = "m" },
        CenterPoint = new Sim.DimensionalVector2d_Length
        {
            Value = new Sim.DecimalVector2d { X = 0, Y = 0 },
            Unit = "m",
        },
        GroundHeight = new Sim.Dimensional_Length { Value = 0, Unit = "m" },
        NorthAngle = new Sim.Dimensional_Angle { Value = 0, Unit = "°" },
        AdvancedSettings = new Sim.AdvancedROISettings
        {
            WindTunnelSize = new Sim.WindTunnelSizeModerate(),
        },
    },
    WindConditions = new Sim.WindConditions
    {
        GeographicalLocation = new Sim.GeographicalLocation
        {
            Latitude = new Sim.Dimensional_Angle { Value = 48.135125, Unit = "°" },
            Longitude = new Sim.Dimensional_Angle { Value = 11.581981, Unit = "°" },
        },
        WindRose = windRose,
    },
    PedestrianComfortMap =
    [
        new Sim.PedestrianComfortSurface
        {
            Name = "Pedestrian level 1",
            HeightAboveGround = new Sim.Dimensional_Length { Value = 1.5, Unit = "m" },
            Ground = new Sim.GroundAbsolute(),
        },
    ],
    SimulationControl = new Sim.WindComfortSimulationControl
    {
        MaxDirectionRunTime = new Sim.Dimensional_Time { Value = 10000, Unit = "s" },
        NumberOfFluidPasses = 0.2,
    },
    AdvancedModelling = new Sim.AdvancedModelling(),
    AdditionalResultExport = new Sim.FluidResultControls
    {
        TransientResultControl = new Sim.TransientResultControl
        {
            WriteControl = new Sim.CoarseResolution(),
            FractionFromEnd = 0.1,
        },
        StatisticalAveragingResultControl = new Sim.StatisticalAveragingResultControlV2
        {
            SamplingInterval = new Sim.CoarseResolution(),
            FractionFromEnd = 0.1,
        },
    },
    MeshSettings = new Sim.WindComfortMesh
    {
        WindComfortFineness = new Sim.PacefishFinenessVeryCoarse(),
    },
};

var simulation = sdk.Simulations.CreateSimulation(projectId, new SimulationSpec
{
    Name = "Pedestrian Wind Comfort via CSharp SDK",
    CadId = cadId,
    StateId = cadStateId,
    Model = model,
});
var simulationId = simulation.SimulationId;
Console.WriteLine($"simulationId: {simulationId}");

// Check simulation setup
var check = sdk.Simulations.CheckSimulationSetup(projectId, simulationId);
var warnings = check.Entries?.Where(e => e.Severity == "WARNING").ToList();
Console.WriteLine($"Simulation check warnings: {warnings?.Count ?? 0}");
if (check.Entries?.Any(e => e.Severity == "ERROR") == true)
    throw new SimScaleOperationError(check, "Simulation setup check failed");

// Estimate simulation
var maxRuntime = 36000;
var estimation = sdk.Simulations.EstimateSimulationSetup(projectId, simulationId);
Console.WriteLine($"Simulation estimation: {estimation}");
if (estimation.ComputeResource?.Value > 10.0)
    throw new Exception("Too expensive");

// Create simulation run, start, and wait
var simulationRun = sdk.SimulationRuns.CreateSimulationRun(projectId, simulationId, new SimulationRun
{
    Name = "Run 1",
});
var runId = simulationRun.RunId;
Console.WriteLine($"runId: {runId}");
sdk.SimulationRuns.StartSimulationRun(projectId, simulationId, runId);
simulationRun = sdk.WaitUntilDone(
    () => sdk.SimulationRuns.GetSimulationRun(projectId, simulationId, runId),
    r => r.Status, timeoutSeconds: maxRuntime);

// Export and download statistical surface solution results
var results = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, runId, category: "STATISTICAL_SURFACE_SOLUTION");
var statisticalSurfaceSolution = (SimulationRunResultSolution)results.Embedded[0];
var exportFormat = statisticalSurfaceSolution.AvailableExportFormats![0];
var exportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = statisticalSurfaceSolution.ResultId,
    Format = exportFormat,
});
var exportResp = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, exportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var solutionZip = Path.Combine(exampleDir, "statistical_surface_solution.zip");
sdk.Download(exportResp.Url!, solutionZip);
using (var zip = ZipFile.OpenRead(solutionZip))
    Console.WriteLine($"Statistical surface solution ZIP content: {string.Join(", ", zip.Entries.Select(e => e.Name))}");

// Generate and download screenshot report
var report = sdk.Reports.CreateReport(projectId, new Rpt.ReportRequest
{
    Name = "Report 1",
    Description = "Simulation report",
    ResultIds = [statisticalSurfaceSolution.ResultId],
    ReportProperties = new Rpt.ScreenshotReportProperties
    {
        ModelSettings = new Rpt.ModelSettings
        {
            Parts =
            [
                new Rpt.Part { PartIdentifier = "solid 1 input - group-all-volumes" },
                new Rpt.Part { PartIdentifier = "Pedestrian level 1" },
            ],
        },
        CameraSettings = new Rpt.TopViewPredefinedCameraSettings
        {
            ProjectionType = "ORTHOGONAL",
            DirectionSpecifier = "Z_NEGATIVE",
        },
        OutputSettings = new Rpt.ScreenshotOutputSettings
        {
            Name = "Output 1",
            Format = "PNG",
            Resolution = new Rpt.ResolutionInfo { X = 1440, Y = 1080 },
            FrameIndex = 0,
            ShowLegend = true,
            ShowCube = false,
        },
    },
});
var reportId = report.ReportId;
Console.WriteLine($"Starting report with ID {reportId}");
sdk.Reports.StartReportJob(projectId, reportId);
var reportResponse = sdk.WaitUntilDone(
    () => sdk.Reports.GetReport(projectId, reportId),
    r => r.Status);
var reportFile = Path.Combine(exampleDir, $"report.{reportResponse.Download!.Format}");
sdk.Download(reportResponse.Download.Url!, reportFile);
Console.WriteLine($"Downloaded report: {reportFile}");

// Additional wind data: reuse directional results with updated simulation spec
// This is optional — useful when running the same simulation with different wind data.
// Only the statistical surface solution is re-calculated; directional results are reused.
var simulationSpec = sdk.Simulations.GetSimulation(projectId, simulationId);
var pwcModel = (Sim.WindComfort)simulationSpec.Model;
pwcModel.PedestrianComfortMap![0].HeightAboveGround = new Sim.Dimensional_Length { Value = 1.8, Unit = "m" };
simulationSpec.Name = "Pedestrian Wind Comfort with additional data";
sdk.Simulations.UpdateSimulation(projectId, simulationId, simulationSpec);

var additionalRun = sdk.SimulationRuns.AddWindDataToSimulationRun(
    projectId, simulationId, runId, new WindData { Name = "Additional wind rose run" });
var additionalRunId = additionalRun.RunId;
additionalRun = sdk.WaitUntilDone(
    () => sdk.SimulationRuns.GetSimulationRun(projectId, simulationId, additionalRunId),
    r => r.Status, timeoutSeconds: maxRuntime);

// Export and download updated statistical surface solution
var updatedResults = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, additionalRunId, category: "STATISTICAL_SURFACE_SOLUTION");
var updatedSolution = (SimulationRunResultSolution)updatedResults.Embedded[0];
var updatedExportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = updatedSolution.ResultId,
    Format = updatedSolution.AvailableExportFormats![0],
});
var updatedExportResp = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, updatedExportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var updatedZip = Path.Combine(exampleDir, "statistical_surface_solution_2.zip");
sdk.Download(updatedExportResp.Url!, updatedZip);
using (var zip = ZipFile.OpenRead(updatedZip))
    Console.WriteLine($"Updated statistical surface solution ZIP content: {string.Join(", ", zip.Entries.Select(e => e.Name))}");

Console.WriteLine("\nDone!");
