using System.IO.Compression;
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;
using Sim = SimScale.Sdk.V1.Models.SimulationModels;
using Geo = SimScale.Sdk.V1.Models.GeometryPrimitiveModels;
using Rpt = SimScale.Sdk.V1.Models.ReportingModels;

// Resolve paths relative to the project directory (works with dotnet run from any location)
var exampleDir = Directory.GetCurrentDirectory();

using var sdk = new SimScaleSDK();

// Create project
var project = sdk.Projects.CreateProject(new Project
{
    Name = "Incompressible LBM via CSharp SDK",
    Description = "Incompressible LBM via CSharp SDK",
    MeasurementSystem = "SI",
});
var projectId = project.ProjectId!;
Console.WriteLine($"projectId: {projectId}");

// Upload and import CAD
var storage = sdk.Upload(Path.Combine(exampleDir, "../fixtures/Shapes.stl"));
var cadImport = sdk.CadImports.ImportCad(projectId, new CadImportRequest
{
    Name = "Shapes",
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

// Get CAD topology mappings for faces
var topology = sdk.Cads.GetCadTopology(
    cadId, cadStateId, @Class: "face", entities: ["Cylinder", "Cube 2", "Sphere"]);
var entityNames = topology.Embedded!.Select(e => e.Name!).ToList();
Console.WriteLine($"entities: [{string.Join(", ", entityNames)}]");

// Upload and import table: Probe Points
var probePointsStorage = sdk.Upload(Path.Combine(exampleDir, "../fixtures/ProbePoints.csv"));
var probePointsTable = sdk.TableImports.ImportTable(projectId, new TableImportRequest
{
    Location = new TableImportRequestLocation { StorageId = probePointsStorage.StorageId! },
});
var probePointsTableId = probePointsTable.TableId!;

// Upload and import table: Inlet Profile
var inletProfileStorage = sdk.Upload(Path.Combine(exampleDir, "../fixtures/InletProfile.csv"));
var inletProfileTable = sdk.TableImports.ImportTable(projectId, new TableImportRequest
{
    Location = new TableImportRequestLocation { StorageId = inletProfileStorage.StorageId! },
});
var inletProfileTableId = inletProfileTable.TableId!;

// Create geometry primitives
var externalFlowDomain = sdk.Simulations.CreateGeometryPrimitive(projectId, new Geo.RotatableCartesianBox
{
    Name = "External Flow Domain",
    Min = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = -350, Y = -100, Z = 0 },
        Unit = "m",
    },
    Max = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = 650, Y = 100, Z = 300 },
        Unit = "m",
    },
    RotationPoint = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = 0, Y = 0, Z = 0 },
        Unit = "m",
    },
    RotationAngles = new Geo.DimensionalVector_Angle
    {
        Value = new Geo.DecimalVector { X = 0, Y = 0, Z = 0 },
        Unit = "\u00b0",
    },
});
var externalFlowDomainUuid = externalFlowDomain.GeometryPrimitiveId;

var meshRegion = sdk.Simulations.CreateGeometryPrimitive(projectId, new Geo.LocalCartesianBox
{
    Name = "Mesh Region",
    OrientationReference = "GEOMETRY",
    Min = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = -30, Y = -30, Z = 0 },
        Unit = "m",
    },
    Max = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector { X = 30, Y = 30, Z = 120 },
        Unit = "m",
    },
});
var meshRegionUuid = meshRegion.GeometryPrimitiveId;

// Define simulation spec
var model = new Sim.IncompressiblePacefish
{
    BoundingBoxUuid = externalFlowDomainUuid,
    FlowDomainBoundaries = new Sim.FlowDomainBoundaries
    {
        Xmin = new Sim.VelocityInletBC
        {
            Name = "Velocity inlet (A)",
            Velocity = new Sim.FixedMagnitudeVBC
            {
                Value = new Sim.DimensionalFunction_Speed
                {
                    Value = new Sim.TableDefinedFunction
                    {
                        TableId = inletProfileTableId,
                        ResultIndex = [2],
                        IndependentVariables =
                        [
                            new Sim.TableFunctionParameter { Reference = 1, Parameter = "HEIGHT", Unit = "m" },
                        ],
                    },
                    Unit = "m/s",
                },
            },
            TurbulenceIntensity = new Sim.TurbulenceIntensityTIBC
            {
                Value = new Sim.DimensionalFunction_Dimensionless
                {
                    Value = new Sim.ConstantFunction { Value = 0.015 },
                    Unit = "",
                },
            },
            DissipationType = new Sim.CustomOmegaDissipation
            {
                Value = new Sim.DimensionalFunction_SpecificTurbulenceDissipationRate
                {
                    Value = new Sim.TableDefinedFunction
                    {
                        TableId = inletProfileTableId,
                        ResultIndex = [3],
                        IndependentVariables =
                        [
                            new Sim.TableFunctionParameter { Reference = 1, Parameter = "HEIGHT", Unit = "m" },
                        ],
                    },
                    Unit = "1/s",
                },
            },
        },
        Xmax = new Sim.PressureOutletBC { Name = "Pressure outlet (B)" },
        Ymin = new Sim.WallBC { Name = "Side (C)", Velocity = new Sim.SlipVBC() },
        Ymax = new Sim.WallBC { Name = "Side (D)", Velocity = new Sim.SlipVBC() },
        Zmin = new Sim.WallBC
        {
            Name = "Ground (E)",
            Velocity = new Sim.NoSlipVBC
            {
                NoSlipWallRoughnessType = new Sim.NoSlipWallEquivalentSandRoughness
                {
                    SurfaceRoughness = new Sim.Dimensional_Length { Value = 0, Unit = "m" },
                },
            },
        },
        Zmax = new Sim.WallBC { Name = "Top (F)", Velocity = new Sim.SlipVBC() },
    },
    SimulationControl = new Sim.FluidSimulationControl
    {
        EndTime = new Sim.Dimensional_Time { Value = 5, Unit = "s" },
    },
    AdvancedModelling = new Sim.AdvancedModelling(),
    ResultControl = new Sim.FluidResultControls
    {
        ForcesMoments =
        [
            new Sim.ForcesMomentsResultControl
            {
                Name = "Forces and moments 1",
                CenterOfRotation = new Sim.DimensionalVector_Length
                {
                    Value = new Sim.DecimalVector { X = 0, Y = 0, Z = 0 },
                    Unit = "m",
                },
                WriteControl = new Sim.HighResolution(),
                ExportStatistics = false,
                GroupAssignments = false,
                TopologicalReference = new Sim.TopologicalReference { Entities = entityNames },
            },
            new Sim.ForcesMomentsResultControl
            {
                Name = "Forces and moments 2",
                CenterOfRotation = new Sim.DimensionalVector_Length
                {
                    Value = new Sim.DecimalVector { X = 0, Y = 0, Z = 0 },
                    Unit = "m",
                },
                WriteControl = new Sim.HighResolution(),
                FractionFromEnd = 0.3,
                TopologicalReference = new Sim.TopologicalReference { Entities = entityNames },
            },
        ],
        ProbePoints =
        [
            new Sim.ProbePointsResultControl
            {
                Name = "Probe point 1",
                WriteControl = new Sim.ModerateResolution(),
                ProbeLocations = new Sim.TableDefinedProbeLocations { TableId = probePointsTableId },
            },
        ],
        TransientResultControl = new Sim.TransientResultControl
        {
            WriteControl = new Sim.CoarseResolution(),
            ExportFluid = true,
            GeometryPrimitiveUuids = [externalFlowDomainUuid],
        },
        StatisticalAveragingResultControl = new Sim.StatisticalAveragingResultControlV2
        {
            SamplingInterval = new Sim.CoarseResolution(),
            ExportFluid = true,
            GeometryPrimitiveUuids = [externalFlowDomainUuid],
            ExportSurface = true,
            TopologicalReference = new Sim.TopologicalReference { Entities = entityNames },
        },
        SnapshotResultControl = new Sim.SnapshotResultControl
        {
            ExportFluid = true,
            GeometryPrimitiveUuids = [externalFlowDomainUuid],
        },
    },
    MeshSettingsNew = new Sim.PacefishAutomesh
    {
        NewFineness = new Sim.PacefishFinenessCoarse(),
        ReferenceLengthComputation = new Sim.AutomaticReferenceLength(),
        PrimaryTopology = new Sim.Region { GeometryPrimitiveUuids = [meshRegionUuid] },
    },
};

var simulation = sdk.Simulations.CreateSimulation(projectId, new SimulationSpec
{
    Name = "Incompressible LBM via CSharp SDK",
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

// Export and download probe point statistical data
var probePointsResults = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, runId, category: "PROBE_POINT_PLOT_STATISTICAL_DATA");
var probeResult = (SimulationRunResultTable)probePointsResults.Embedded[0];
var probeExportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = probeResult.ResultId,
    Format = "CSV",
});
var probeExport = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, probeExportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var probeCsv = Path.Combine(exampleDir, "probe_points.csv");
sdk.Download(probeExport.Url!, probeCsv);
Console.WriteLine($"Downloaded {probeCsv} ({new FileInfo(probeCsv).Length} bytes)");

// Export and download averaged solution fields
var averagedSolutionResults = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, runId, category: "AVERAGED_SOLUTION");
var averagedSolution = (SimulationRunResultSolution)averagedSolutionResults.Embedded[0];
var solutionExportFormat = averagedSolution.AvailableExportFormats![0];
var solutionExportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = averagedSolution.ResultId,
    Format = solutionExportFormat,
});
var solutionExport = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, solutionExportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var averagedSolutionZip = Path.Combine(exampleDir, "averaged_solution.zip");
sdk.Download(solutionExport.Url!, averagedSolutionZip);
using (var zip = ZipFile.OpenRead(averagedSolutionZip))
    Console.WriteLine($"Averaged solution ZIP content: {string.Join(", ", zip.Entries.Select(e => e.Name))}");

// Generate and download screenshot report
var report = sdk.Reports.CreateReport(projectId, new Rpt.ReportRequest
{
    Name = "Report 1",
    Description = "Simulation report",
    ResultIds = [averagedSolution.ResultId],
    ReportProperties = new Rpt.ScreenshotReportProperties
    {
        ModelSettings = new Rpt.ModelSettings
        {
            Parts = [],
            ScalarField = new Rpt.ScalarField
            {
                FieldName = "Velocity",
                Component = "Magnitude",
                DataType = "CELL",
            },
        },
        Filters = new Rpt.Filters
        {
            CuttingPlanes =
            [
                new Rpt.CuttingPlane
                {
                    Name = "velocity-plane",
                    ScalarField = new Rpt.ScalarField
                    {
                        FieldName = "Velocity",
                        Component = "Magnitude",
                        DataType = "CELL",
                    },
                    Center = new Rpt.Vector3D { X = 150, Y = 0, Z = 150 },
                    Normal = new Rpt.Vector3D { X = 0, Y = 1, Z = 0 },
                    Opacity = 1,
                    Clipping = true,
                    RenderMode = "SURFACES",
                },
            ],
        },
        CameraSettings = new Rpt.TopViewPredefinedCameraSettings
        {
            ProjectionType = "ORTHOGONAL",
            DirectionSpecifier = "Y_POSITIVE",
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

Console.WriteLine("\nDone!");
