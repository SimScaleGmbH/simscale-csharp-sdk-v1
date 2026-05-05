using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.CadModels;

namespace SimScale.Sdk.V1.Resources;

public class Cads
{
    private readonly SimScaleClient _client;

    public Cads(SimScaleClient client) => _client = client;

    /// <summary>Create a CAD saved selection Create a CAD saved selection. This operation creates a new CAD state.</summary>
    public CreateSavedSelectionResponse CreateCadStateSavedSelection(
        Guid cadId,
        Guid cadStateId,
        CreateSavedSelectionRequest body
    )
    {
        return _client.Request<CreateSavedSelectionResponse>(HttpMethod.Post, $"/cads/{cadId}/states/{cadStateId}/savedselections", body);
    }

    /// <summary>Download original CAD file Get a temporary link to download the originally imported CAD file.</summary>
    public DownloadOriginalCadResponse DownloadOriginalCad(
        Guid cadId,
        Guid cadStateId
    )
    {
        return _client.Request<DownloadOriginalCadResponse>(HttpMethod.Get, $"/cads/{cadId}/states/{cadStateId}/downloadoriginal");
    }

    /// <summary>Get information about the CAD</summary>
    public Cad GetCad(
        string projectId,
        Guid cadId
    )
    {
        return _client.Request<Cad>(HttpMethod.Get, $"/projects/{projectId}/cads/{cadId}");
    }

    /// <summary>Get detailed information about the CAD state</summary>
    public CadState GetCadState(
        Guid cadId,
        Guid cadStateId
    )
    {
        return _client.Request<CadState>(HttpMethod.Get, $"/cads/{cadId}/states/{cadStateId}");
    }

    /// <summary>List CAD topology with entity attributes Assignment of topological entities (e.g. faces, bodies) in the simulation setup is a non-trivial task. Complex models can consist of several assemblies which may contain multiple occurrences of bodies and their entities. In order to identify an assignment unambiguously, the full path from the root part of the model to the actual topological entity is required. SimScale generates unique internal names for all topological entities of a model during the CAD import which are used for assignments within the simulation spec. Examples of internal names are `B1_TE5` or `A1_I26_A5_I27_B102_TE196`. This API endpoint lists the CAD model’s topology with all relevant attributes for each entity, such as: * The topological entity class (body or face) * The original body and entity names * Entity attributes like `SDL/TYSA_NAME`, `SDL/TYSA_UNAME`, `ATTRIB_XPARASOLID_NAME` or `SDL/TYSA_COLOUR` * The path from the root of the model Please note that during the CAD import the model's topology can be modified (e.g. when the facet split option is enabled). This means that there might not be a 1:1 mapping between the internal and original names.</summary>
    public CadTopology GetCadTopology(
        Guid cadId,
        Guid cadStateId,
        int? limit = null,
        int? page = null,
        string? @Class = null,
        string[]? bodies = null,
        string[]? entities = null,
        string[]? attributes = null,
        string[]? values = null
    )
    {
        return _client.Request<CadTopology>(HttpMethod.Get, $"/cads/{cadId}/states/{cadStateId}/topology",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page, ["class"] = @Class, ["bodies"] = bodies, ["entities"] = entities, ["attributes"] = attributes, ["values"] = values });
    }

    /// <summary>List CADs within a project All CADs in the project are included in the list, however not all of them can be used in a meshing or simulation setup.</summary>
    public Models.Cads GetCads(
        string projectId,
        int? limit = null,
        int? page = null
    )
    {
        return _client.Request<Models.Cads>(HttpMethod.Get, $"/projects/{projectId}/cads",
            queryParams: new Dictionary<string, object?> { ["limit"] = limit, ["page"] = page });
    }

    /// <summary>Run a CAD query Run a CAD query on a given CAD state. CAD queries that involve complex computation might take some time to complete. Please refer to the following steps to run a CAD query: 1. Trigger the query computation via `POST /cads/{cadId}/states/{cadStateId}/query` 2. Monitor progress via `POST /cads/{cadId}/states/{cadStateId}/query`</summary>
    public CadQueryResponse QueryCadState(
        Guid cadId,
        Guid cadStateId,
        CadQueryRequest body
    )
    {
        return _client.Request<CadQueryResponse>(HttpMethod.Post, $"/cads/{cadId}/states/{cadStateId}/query", body);
    }

    /// <summary>Rename the CAD Rename the CAD. This operation creates a new CAD state.</summary>
    public RenameCadResponse RenameCadState(
        Guid cadId,
        Guid cadStateId,
        RenameCadRequest body
    )
    {
        return _client.Request<RenameCadResponse>(HttpMethod.Post, $"/cads/{cadId}/states/{cadStateId}/rename", body);
    }
}
