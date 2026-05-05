using System.IO.Compression;
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;
using Sim = SimScale.Sdk.V1.Models.SimulationModels;
using Mesh = SimScale.Sdk.V1.Models.MeshingModels;
using Geo = SimScale.Sdk.V1.Models.GeometryPrimitiveModels;
using Rpt = SimScale.Sdk.V1.Models.ReportingModels;

// Resolve paths relative to the project directory (works with dotnet run from any location)
var exampleDir = Directory.GetCurrentDirectory();

using var sdk = new SimScaleSDK();

// Create project
var project = sdk.Projects.CreateProject(new Project
{
    Name = "Incompressible via CSharp SDK",
    Description = "Incompressible via CSharp SDK",
    MeasurementSystem = "SI",
});
var projectId = project.ProjectId!;
Console.WriteLine($"projectId: {projectId}");

// Upload and import CAD
var storage = sdk.Upload(Path.Combine(exampleDir, "../fixtures/pipe_junction_model_tutorial.x_t"));
var cadImport = sdk.CadImports.ImportCad(projectId, new CadImportRequest
{
    Name = "CAD-pipe-junction_v1",
    Location = new CadImportRequestLocation { StorageId = storage.StorageId! },
    Format = "PARASOLID",
    InputUnit = CadUnit.M,
    Options = new CadImportRequestOptions
    {
        FacetSplit = false,
        Sewing = false,
        Improve = true,
        OptimizeForLBMSolver = false,
    },
});
var cadId = cadImport.CadId;
cadImport = sdk.WaitUntilDone(
    () => sdk.CadImports.GetImportedCad(projectId, cadId),
    r => r.Status, timeoutSeconds: 900, intervalMs: 10_000);
var cadStateId = cadImport.CadStateId;
Console.WriteLine($"cadId: {cadId}, cadStateId: {cadStateId}");

// Get CAD topology mappings
string GetSingleEntityName(Guid cadId, Guid cadStateId, string value)
{
    var entities = sdk.Cads.GetCadTopology(cadId, cadStateId,
        attributes: ["SDL/TYSA_NAME"], values: [value]).Embedded;
    if (entities.Count == 1)
        return entities[0].Name!;
    throw new InvalidOperationException($"Found {entities.Count} entities instead of 1");
}

var materialEntity = GetSingleEntityName(cadId, cadStateId, "Fluid Region");
var inlet1Entity = GetSingleEntityName(cadId, cadStateId, "Face ZMAX");
var inlet2Entity = GetSingleEntityName(cadId, cadStateId, "Face Junction");
var outletEntity = GetSingleEntityName(cadId, cadStateId, "Face YMAX");

// Create geometry primitive (probe point)
var geometryPrimitive = sdk.Simulations.CreateGeometryPrimitive(projectId, new Geo.Point
{
    Name = "Point 1",
    Center = new Geo.DimensionalVector_Length
    {
        Value = new Geo.DecimalVector
        {
            X = 0.0035744310360600745,
            Y = 0.4499999880790711,
            Z = -0.4507558972231502,
        },
        Unit = "m",
    },
});
var geometryPrimitiveUuid = geometryPrimitive.GeometryPrimitiveId;

// Create simulation spec
var model = new Sim.Incompressible
{
    TurbulenceModel = "KOMEGASST",
    Algorithm = "SIMPLE",
    NumOfPassiveSpecies = 0,
    Model = new Sim.FluidModel(),
    InitialConditions = new Sim.FluidInitialConditions(),
    AdvancedConcepts = new Sim.AdvancedConcepts(),
    Materials = new Sim.IncompressibleFluidMaterials(),
    Numerics = new Sim.FluidNumerics
    {
        RelaxationFactor = new Sim.RelaxationFactor(),
        PressureReferenceValue = new Sim.Dimensional_Pressure { Value = 0, Unit = "Pa" },
        ResidualControls = new Sim.ResidualControls
        {
            Velocity = new Sim.Tolerance(),
            Pressure = new Sim.Tolerance(),
            TurbulentKineticEnergy = new Sim.Tolerance(),
            OmegaDissipationRate = new Sim.Tolerance(),
        },
        Solvers = new Sim.FluidSolvers(),
        Schemes = new Sim.Schemes
        {
            TimeDifferentiation = new Sim.TimeDifferentiationSchemes(),
            Gradient = new Sim.GradientSchemes(),
            Divergence = new Sim.DivergenceSchemes(),
            Laplacian = new Sim.LaplacianSchemes(),
            Interpolation = new Sim.InterpolationSchemes(),
            SurfaceNormalGradient = new Sim.SurfaceNormalGradientSchemes(),
        },
    },
    BoundaryConditions =
    [
        new Sim.VelocityInletBC
        {
            Name = "Velocity inlet 1",
            Velocity = new Sim.FixedValueVBC
            {
                Value = new Sim.DimensionalVectorFunction_Speed
                {
                    Unit = "m/s",
                    Value = new Sim.ComponentVectorFunction
                    {
                        X = new Sim.ConstantFunction { Value = 0 },
                        Y = new Sim.ConstantFunction { Value = 0 },
                        Z = new Sim.ConstantFunction { Value = -1.5 },
                    },
                },
            },
            TopologicalReference = new Sim.TopologicalReference { Entities = [inlet1Entity] },
        },
        new Sim.VelocityInletBC
        {
            Name = "Velocity inlet 2",
            Velocity = new Sim.FixedValueVBC
            {
                Value = new Sim.DimensionalVectorFunction_Speed
                {
                    Unit = "m/s",
                    Value = new Sim.ComponentVectorFunction
                    {
                        X = new Sim.ConstantFunction { Value = 0 },
                        Y = new Sim.ConstantFunction { Value = -1 },
                        Z = new Sim.ConstantFunction { Value = 0 },
                    },
                },
            },
            TopologicalReference = new Sim.TopologicalReference { Entities = [inlet2Entity] },
        },
        new Sim.PressureOutletBC
        {
            Name = "Pressure outlet 3",
            GaugePressure = new Sim.FixedValuePBC
            {
                Value = new Sim.DimensionalFunction_Pressure
                {
                    Value = new Sim.ConstantFunction { Value = 0 },
                    Unit = "Pa",
                },
            },
            TopologicalReference = new Sim.TopologicalReference { Entities = [outletEntity] },
        },
    ],
    SimulationControl = new Sim.FluidSimulationControl
    {
        EndTime = new Sim.Dimensional_Time { Value = 100, Unit = "s" },
        DeltaT = new Sim.Dimensional_Time { Value = 1, Unit = "s" },
        WriteControl = new Sim.TimeStepWriteControl { WriteInterval = 20 },
        MaxRunTime = new Sim.Dimensional_Time { Value = 10000, Unit = "s" },
        DecomposeAlgorithm = new Sim.ScotchDecomposeAlgorithm(),
    },
    ResultControl = new Sim.FluidResultControls
    {
        ProbePoints =
        [
            new Sim.ProbePointsResultControl
            {
                Name = "Probe point 1",
                WriteControl = new Sim.TimeStepWriteControl { WriteInterval = 1 },
                GeometryPrimitiveUuids = [geometryPrimitiveUuid],
            },
        ],
    },
};

var simulation = sdk.Simulations.CreateSimulation(projectId, new SimulationSpec
{
    Name = "Incompressible via CSharp SDK",
    CadId = cadId,
    StateId = cadStateId,
    Model = model,
});
var simulationId = simulation.SimulationId;
Console.WriteLine($"simulationId: {simulationId}");

// Add material and assign to fluid region
var materialData = sdk.GetMaterial("Water");
sdk.Simulations.UpdateSimulationMaterials(projectId, simulationId, new MaterialUpdateRequest
{
    Operations =
    [
        new MaterialUpdateOperation
        {
            Path = "/materials/fluids",
            MaterialData = materialData,
        },
    ],
});
var simulationSpec = sdk.Simulations.GetSimulation(projectId, simulationId);
var incompModel = (Sim.Incompressible)simulationSpec.Model;
incompModel.Materials!.Fluids![0].TopologicalReference = new Sim.TopologicalReference
{
    Entities = [materialEntity],
};
sdk.Simulations.UpdateSimulation(projectId, simulationId, simulationSpec);

// Create, check, and run mesh operation
var meshOperation = sdk.MeshOperations.CreateMeshOperation(projectId, new MeshOperation
{
    Name = "Pipe junction mesh",
    CadId = cadId,
    StateId = cadStateId,
    Model = new Mesh.SimmetrixMeshingFluid
    {
        PhysicsBasedMeshing = true,
        AutomaticLayerSettings = new Mesh.AutomaticLayerOn(),
    },
});
var meshOperationId = meshOperation.MeshOperationId;
Console.WriteLine($"meshOperationId: {meshOperationId}");
var meshCheck = sdk.MeshOperations.CheckMeshOperationSetup(projectId, meshOperationId, simulationId: simulationId);
if (meshCheck.Entries?.Any(e => e.Severity == "ERROR") == true)
    throw new SimScaleOperationError(meshCheck, "Mesh setup check failed");
sdk.MeshOperations.StartMeshOperation(projectId, meshOperationId, simulationId: simulationId);
meshOperation = sdk.WaitUntilDone(
    () => sdk.MeshOperations.GetMeshOperation(projectId, meshOperationId),
    r => r.Status);
Console.WriteLine($"Meshing finished. meshId: {meshOperation.MeshId}");

// Assign mesh to simulation
simulationSpec = sdk.Simulations.GetSimulation(projectId, simulationId);
simulationSpec.MeshId = meshOperation.MeshId;
sdk.Simulations.UpdateSimulation(projectId, simulationId, simulationSpec);

// Check simulation setup and run
var check = sdk.Simulations.CheckSimulationSetup(projectId, simulationId);
if (check.Entries?.Any(e => e.Severity == "ERROR") == true)
    throw new SimScaleOperationError(check, "Simulation setup check failed");
var simulationRun = sdk.SimulationRuns.CreateSimulationRun(projectId, simulationId, new SimulationRun
{
    Name = "Run 1",
});
var runId = simulationRun.RunId;
Console.WriteLine($"runId: {runId}");
sdk.SimulationRuns.StartSimulationRun(projectId, simulationId, runId);
simulationRun = sdk.WaitUntilDone(
    () => sdk.SimulationRuns.GetSimulationRun(projectId, simulationId, runId),
    r => r.Status);

// Export and download probe point results
var probePointResults = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, runId, category: "PROBE_POINT_PLOT");
var probeExportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = ((SimulationRunResultPlot)probePointResults.Embedded[0]).ResultId,
    Format = "CSV",
});
var probeExport = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, probeExportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var probeCsv = Path.Combine(exampleDir, "probe_points.csv");
sdk.Download(probeExport.Url!, probeCsv);
Console.WriteLine($"Downloaded {probeCsv} ({new FileInfo(probeCsv).Length} bytes)");

// Export and download solution fields
var solutionResults = sdk.SimulationRuns.GetSimulationRunResults(
    projectId, simulationId, runId, category: "SOLUTION");
var solutionResult = (SimulationRunResultSolution)solutionResults.Embedded[0];
var solutionExportReq = sdk.Export.CreateExport(projectId, new CreateExportRequest
{
    ResultId = solutionResult.ResultId,
    Format = "OPEN_FOAM",
});
var solutionExport = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, solutionExportReq.ExportId),
    r => r.Status, intervalMs: 5_000);
var solutionZip = Path.Combine(exampleDir, "solution.zip");
sdk.Download(solutionExport.Url!, solutionZip);
using (var zip = ZipFile.OpenRead(solutionZip))
    Console.WriteLine($"Solution ZIP content: {string.Join(", ", zip.Entries.Select(e => e.Name))}");

// Generate and download animation report
var report = sdk.Reports.CreateReport(projectId, new Rpt.ReportRequest
{
    Name = "Report 1",
    Description = "Simulation report",
    ResultIds = [solutionResult.ResultId],
    ReportProperties = new Rpt.AnimationReportProperties
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
                    Center = new Rpt.Vector3D { X = 0, Y = 0, Z = 0 },
                    Normal = new Rpt.Vector3D { X = 1, Y = 0, Z = 0 },
                    Opacity = 1,
                    Clipping = true,
                    RenderMode = "SURFACES",
                },
            ],
        },
        CameraSettings = new Rpt.TopViewPredefinedCameraSettings
        {
            ProjectionType = "ORTHOGONAL",
            DirectionSpecifier = "X_POSITIVE",
        },
        OutputSettings = new Rpt.TimeStepAnimationOutputSettings
        {
            Name = "Output 1",
            Format = "MP4",
            Resolution = new Rpt.ResolutionInfo { X = 1440, Y = 1080 },
            FromFrameIndex = 0,
            ToFrameIndex = 5,
            SkipFrames = 0,
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
