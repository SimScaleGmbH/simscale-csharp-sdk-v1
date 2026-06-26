using System.Text.Json;
using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;
using DataRepositoryModels = SimScale.Sdk.V1.Models.DataRepositoryModels;
using WorkflowRepositoryModels = SimScale.Sdk.V1.Models.WorkflowRepositoryModels;
using WorkflowRunnerModels = SimScale.Sdk.V1.Models.WorkflowRunnerModels;

var exampleDir = Directory.GetCurrentDirectory();

var inputFile = Path.Combine(exampleDir, "../fixtures/cube_with_results_ascii.vtu");
const string InputContentType = "application/octet-stream";

const string WorkflowType = "simscale.ramps:mesh-and-result-import:1.3.1";
const string InputDataType = "simscale.ramps:general-mesh-and-fields:1.0.0";
const string InputName = "generalMeshAndFields";
const string OutputName = "rampsMeshAndFields";

using var sdk = new SimScaleSDK();

// Create project
var project = sdk.Projects.CreateProject(new Project
{
    Name = "Mesh and result import via CSharp SDK",
    Description = "Mesh and result import via CSharp SDK",
    MeasurementSystem = "SI",
});
var projectId = project.ProjectId!;
Console.WriteLine($"projectId: {projectId}");

// Upload workflow input data
var inputDataId = sdk.UploadToDataRepository(
    inputFile,
    projectId,
    InputDataType,
    contentType: InputContentType);
Console.WriteLine($"inputDataId: {inputDataId}");

// Create workflow
var workflowId = sdk.WorkflowRepository.CreateWorkflow(
    new WorkflowRepositoryModels.CreateWorkflowRequest
    {
        ProjectId = projectId,
        WorkflowTypeReference = WorkflowType,
        Name = "VTU mesh and result import",
        Description = "Import a VTU mesh and result field into SimScale.",
        InputDataMap = sdk.CreateNonParametricWorkflowDataMap(new Dictionary<string, string>
        {
            [InputName] = inputDataId,
        }),
        Configuration = JsonSerializer.SerializeToElement(new Dictionary<string, object>()),
    });
Console.WriteLine($"workflowId: {workflowId}");

// Initialize and start workflow run
var workflow = sdk.WorkflowRepository.ReadWorkflow(workflowId);
var workflowVersionId = workflow.WorkflowVersionId;
Console.WriteLine($"workflowVersionId: {workflowVersionId}");

var workflowRunId = sdk.WorkflowRunner.InitializeWorkflowRun(
    new WorkflowRunnerModels.InitializeWorkflowRunRequest
    {
        WorkflowVersionId = workflowVersionId,
        WorkflowRunMode = "REAL",
        WorkflowRunName = "VTU import",
    });
Console.WriteLine($"workflowRunId: {workflowRunId}");

sdk.WorkflowRunner.StartWorkflowRun(workflowRunId);

var workflowRun = sdk.WaitUntilDone(
    () => sdk.WorkflowRunner.GetWorkflowRun(workflowRunId),
    response => response.State,
    intervalMs: 15_000,
    raiseOnFailure: false);
Console.WriteLine($"workflowRunState: {workflowRun.State}");

if (workflowRun.State != "SUCCEEDED")
{
    var progress = sdk.WorkflowRunner.GetWorkflowRunProgress(workflowRunId);
    throw new InvalidOperationException(
        $"Workflow run did not succeed. State: {workflowRun.State}. Progress: {progress}");
}

// Resolve the workflow output data and export the RAMPS result
var outputDataId = sdk.GetNonParametricWorkflowDataId(workflowRun.OutputDataMap, OutputName);
if (outputDataId is null)
    throw new InvalidOperationException($"Output data ID for {OutputName} was not found");
Console.WriteLine($"outputDataId: {outputDataId}");

var outputDataInfo = sdk.DataRepository.GetDataInfo(outputDataId);
if (outputDataInfo is not DataRepositoryModels.ExternalDataInfo externalDataInfo
    || string.IsNullOrEmpty(externalDataInfo.ExternalReference))
    throw new InvalidOperationException("Output data metadata did not contain ExternalReference");
Console.WriteLine($"rampsResultId: {externalDataInfo.ExternalReference}");

var exportResponse = sdk.Export.CreateExport(
    projectId,
    new CreateExportRequest
    {
        ResultId = Guid.Parse(externalDataInfo.ExternalReference),
        Format = "VTK",
    });

var export = sdk.WaitUntilDone(
    () => sdk.Export.GetExport(projectId, exportResponse.ExportId),
    response => response.Status,
    intervalMs: 5_000);
if (export.Url is null)
    throw new InvalidOperationException("Export completed without a download URL");

var outputFile = Path.Combine(exampleDir, "workflow_mesh_and_result_import_result.zip");
sdk.Download(export.Url, outputFile);
Console.WriteLine($"downloadedResult: {outputFile}");

Console.WriteLine("\nDone!");
