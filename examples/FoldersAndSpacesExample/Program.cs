using SimScale.Sdk.V1;
using SimScale.Sdk.V1.Models;

using var sdk = new SimScaleSDK();

// Get info about the user Personal Space
var userSpaces = sdk.Spaces.GetUserSpaces();
var personalSpaceId = userSpaces.PersonalSpaces![0].SpaceId!;
var personalSpaceInfo = sdk.Spaces.GetSpaceInfo(personalSpaceId);
Console.WriteLine($"Personal Space ID: {personalSpaceId} - Space info: {personalSpaceInfo}");

// Create Folders in the Space root
var folderA = sdk.Folders.CreateFolder(personalSpaceId, new Folder { Name = "Folder A" });
Console.WriteLine($"Created a folder with ID '{folderA.FolderId}' and name '{folderA.Name}' in the Space root");

var folderB = sdk.Folders.CreateFolder(personalSpaceId, new Folder { Name = "Folder B" });
Console.WriteLine($"Created a folder with ID '{folderB.FolderId}' and name '{folderB.Name}' in the Space root");

// Create a Project in the Space root
var projectA = sdk.Projects.CreateProject(new Project
{
    Name = "Project A",
    Description = "Project in Space root",
    MeasurementSystem = "SI",
    SpaceId = personalSpaceId,
});
Console.WriteLine($"Created a project with ID '{projectA.ProjectId}' and name '{projectA.Name}' in the Space root");

// Create a Project inside Folder A
var projectB = sdk.Projects.CreateProject(new Project
{
    Name = "Project B",
    Description = "Project in Folder A",
    MeasurementSystem = "SI",
    SpaceId = personalSpaceId,
    ParentFolderId = folderA.FolderId,
});
Console.WriteLine($"Created a project with ID '{projectB.ProjectId}' and name '{projectB.Name}' inside Folder A");

// Create a Folder inside Folder A
var folderC = sdk.Folders.CreateFolder(personalSpaceId, new Folder
{
    Name = "Folder C",
    ParentFolderId = folderA.FolderId,
});
Console.WriteLine($"Created a folder with ID '{folderC.FolderId}' and name '{folderC.Name}' inside Folder A");

// Rename Folder C
folderC = sdk.Folders.UpdateFolder(personalSpaceId, folderC.FolderId!, new Folder
{
    Name = "New name for Folder C",
});
Console.WriteLine($"Updated folder with ID '{folderC.FolderId}'. New name: '{folderC.Name}'");

// List the contents of the Space root
var foldersInSpaceRoot = sdk.Folders.ListFoldersInSpaceRoot(personalSpaceId);
Console.WriteLine($"Number of folders in Space root: {foldersInSpaceRoot.Total} - Sample: {foldersInSpaceRoot.Embedded[0].Name}");

var projectsInSpaceRoot = sdk.Folders.ListProjectsInSpaceRoot(personalSpaceId);
Console.WriteLine($"Number of projects in Space root: {projectsInSpaceRoot.Total} - Sample: {projectsInSpaceRoot.Embedded[0].Name}");

// List the contents of Folder A
var foldersInFolder = sdk.Folders.ListFoldersInFolder(personalSpaceId, folderA.FolderId!);
Console.WriteLine($"Number of folders in Folder A: {foldersInFolder.Total}");

var projectsInFolder = sdk.Folders.ListProjectsInFolder(personalSpaceId, folderA.FolderId!);
Console.WriteLine($"Number of projects in Folder A: {projectsInFolder.Total}");

// Move content from the Space root to Folder B
sdk.Folders.MoveContentFromSpaceRoot(personalSpaceId, new MoveContentRequest
{
    Entries =
    [
        new ResourceToMove { ProjectId = projectA.ProjectId },
        new ResourceToMove { FolderId = folderA.FolderId },
    ],
    To = new ResourceLocation
    {
        SpaceId = personalSpaceId,
        ParentFolderId = folderB.FolderId,
    },
});
Console.WriteLine("Moved Project A and Folder A into Folder B");

// Move content from Folder A to the Space root
sdk.Folders.MoveContentFromFolder(personalSpaceId, folderA.FolderId!, new MoveContentRequest
{
    Entries =
    [
        new ResourceToMove { ProjectId = projectB.ProjectId },
        new ResourceToMove { FolderId = folderC.FolderId },
    ],
    To = new ResourceLocation
    {
        SpaceId = personalSpaceId,
    },
});
Console.WriteLine("Moved Project B and Folder C back to Space root");

// Clean up — delete everything we created
sdk.Folders.DeleteFolder(personalSpaceId, folderC.FolderId!);
Console.WriteLine("Deleted Folder C");
sdk.Folders.MoveContentFromSpaceRoot(personalSpaceId, new MoveContentRequest
{
    Entries = [new ResourceToMove { ProjectId = projectB.ProjectId }],
    To = new ResourceLocation { SpaceId = personalSpaceId, ParentFolderId = folderB.FolderId },
});
sdk.Folders.DeleteFolder(personalSpaceId, folderB.FolderId!);
Console.WriteLine("Deleted Folder B and all remaining content");

Console.WriteLine("\nDone!");
