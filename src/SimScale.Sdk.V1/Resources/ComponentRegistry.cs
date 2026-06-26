using System.Text.Json;
using SimScale.Sdk.V1.Models;
using SimScale.Sdk.V1.Models.ComponentRegistryModels;
using SimScale.Sdk.V1.Models.WorkflowsModels;

namespace SimScale.Sdk.V1.Resources;

public class ComponentRegistry
{
    private readonly SimScaleClient _client;

    public ComponentRegistry(SimScaleClient client) => _client = client;

    /// <summary>Read the metadata of a component group.</summary>
    public ComponentGroupMetadata GetComponentGroupMetadata(
        string componentGroupReference,
        string? language = null
    )
    {
        return _client.Request<ComponentGroupMetadata>(HttpMethod.Get, $"/component-registry/component-groups/{componentGroupReference}",
            queryParams: new Dictionary<string, object?> { ["language"] = language });
    }

    /// <summary>Read an overview of a component.</summary>
    public ComponentOverview GetComponentMetadata(
        string componentReference,
        string? language = null
    )
    {
        return _client.Request<ComponentOverview>(HttpMethod.Get, $"/component-registry/components/{componentReference}",
            queryParams: new Dictionary<string, object?> { ["language"] = language });
    }

    /// <summary>List the dependencies of a component version.</summary>
    public ComponentVersionDependencies GetComponentVersionDependencies(
        string componentVersionReference
    )
    {
        return _client.Request<ComponentVersionDependencies>(HttpMethod.Get, $"/component-registry/component-versions/{componentVersionReference}/dependencies");
    }

    /// <summary>List the dependents of a component version.</summary>
    public ComponentVersionDependents GetComponentVersionDependents(
        string componentVersionReference
    )
    {
        return _client.Request<ComponentVersionDependents>(HttpMethod.Get, $"/component-registry/component-versions/{componentVersionReference}/dependents");
    }

    /// <summary>Read the metadata of a component version.</summary>
    public ComponentVersionMetadata GetComponentVersionMetadata(
        string componentVersionReference
    )
    {
        return _client.Request<ComponentVersionMetadata>(HttpMethod.Get, $"/component-registry/component-versions/{componentVersionReference}");
    }

    /// <summary>Read the file-operations description of a data type version.</summary>
    public DataTypeFileOperationsDescription GetDataTypeFileOperations(
        string componentVersionReference
    )
    {
        return _client.Request<DataTypeFileOperationsDescription>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/file-operations");
    }

    /// <summary>Read the metadata schema of a data type version.</summary>
    public SchemaDefinition GetDataTypeMetadataSchema(
        string componentVersionReference,
        bool? resolveDependencies = null
    )
    {
        return _client.Request<SchemaDefinition>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/metadata-schema",
            queryParams: new Dictionary<string, object?> { ["resolveDependencies"] = resolveDependencies });
    }

    /// <summary>Read the metadata schema validation rules of a data type version.</summary>
    public ValidationRuleSet GetDataTypeMetadataSchemaValidationRules(
        string componentVersionReference
    )
    {
        return _client.Request<ValidationRuleSet>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/metadata-schema-validation-rules");
    }

    /// <summary>Read the data schema of a data type version.</summary>
    public SchemaDefinition GetDataTypeSchema(
        string componentVersionReference,
        bool? resolveDependencies = null
    )
    {
        return _client.Request<SchemaDefinition>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/schema",
            queryParams: new Dictionary<string, object?> { ["resolveDependencies"] = resolveDependencies });
    }

    /// <summary>Read the data schema validation rules of a data type version.</summary>
    public ValidationRuleSet GetDataTypeSchemaValidationRules(
        string componentVersionReference
    )
    {
        return _client.Request<ValidationRuleSet>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/schema-validation-rules");
    }

    /// <summary>Read the UI schema of a data type version.</summary>
    public SchemaDefinition GetDataTypeUiSchema(
        string componentVersionReference
    )
    {
        return _client.Request<SchemaDefinition>(HttpMethod.Get, $"/component-registry/data-types/{componentVersionReference}/ui-schema");
    }

    /// <summary>Read the configuration schema of a method version.</summary>
    public SchemaDefinition GetMethodConfigurationSchema(
        string componentVersionReference,
        bool? resolveDependencies = null
    )
    {
        return _client.Request<SchemaDefinition>(HttpMethod.Get, $"/component-registry/methods/{componentVersionReference}/configuration-schema",
            queryParams: new Dictionary<string, object?> { ["resolveDependencies"] = resolveDependencies });
    }

    /// <summary>Read the configuration schema validation rules of a method version.</summary>
    public ValidationRuleSet GetMethodConfigurationSchemaValidationRules(
        string componentVersionReference
    )
    {
        return _client.Request<ValidationRuleSet>(HttpMethod.Get, $"/component-registry/methods/{componentVersionReference}/configuration-schema-validation-rules");
    }

    /// <summary>Read the data interface of a method version.</summary>
    public DataInterface GetMethodDataInterface(
        string componentVersionReference
    )
    {
        return _client.Request<DataInterface>(HttpMethod.Get, $"/component-registry/methods/{componentVersionReference}/data-interface");
    }

    /// <summary>Read the resource estimation model of a method version.</summary>
    public MethodResourceEstimationValueModel GetMethodResourceEstimation(
        string componentVersionReference
    )
    {
        return _client.Request<MethodResourceEstimationValueModel>(HttpMethod.Get, $"/component-registry/methods/{componentVersionReference}/resource-estimation");
    }

    /// <summary>Read the metadata of the organization component group.</summary>
    public OrganizationComponentGroupMetadata GetOrganizationComponentGroupMetadata(
        string organizationReference
    )
    {
        return _client.Request<OrganizationComponentGroupMetadata>(HttpMethod.Get, $"/component-registry/organization-component-groups/{organizationReference}");
    }

    /// <summary>Read the configuration schema of a workflow type version.</summary>
    public SchemaDefinition GetWorkflowTypeConfigurationSchema(
        string componentVersionReference,
        bool? resolveDependencies = null
    )
    {
        return _client.Request<SchemaDefinition>(HttpMethod.Get, $"/component-registry/workflow-types/{componentVersionReference}/configuration-schema",
            queryParams: new Dictionary<string, object?> { ["resolveDependencies"] = resolveDependencies });
    }

    /// <summary>Read the configuration schema validation rules of a workflow type version.</summary>
    public ValidationRuleSet GetWorkflowTypeConfigurationSchemaValidationRules(
        string componentVersionReference
    )
    {
        return _client.Request<ValidationRuleSet>(HttpMethod.Get, $"/component-registry/workflow-types/{componentVersionReference}/configuration-schema-validation-rules");
    }

    /// <summary>Read the data interface of a workflow type version.</summary>
    public DataInterface GetWorkflowTypeDataInterface(
        string componentVersionReference
    )
    {
        return _client.Request<DataInterface>(HttpMethod.Get, $"/component-registry/workflow-types/{componentVersionReference}/data-interface");
    }

    /// <summary>Read the UI configuration of a workflow type version.</summary>
    public UiConfiguration GetWorkflowTypeUiConfiguration(
        string componentVersionReference
    )
    {
        return _client.Request<UiConfiguration>(HttpMethod.Get, $"/component-registry/workflow-types/{componentVersionReference}/ui-configuration");
    }

    /// <summary>Read the workflow definition of a workflow type version.</summary>
    public WorkflowDefinition GetWorkflowTypeWorkflowDefinition(
        string componentVersionReference
    )
    {
        return _client.Request<WorkflowDefinition>(HttpMethod.Get, $"/component-registry/workflow-types/{componentVersionReference}/workflow-definition");
    }

    /// <summary>List the subgroups of a component group.</summary>
    public List<ComponentGroupMetadata> ListComponentSubgroups(
        string componentGroupReference,
        int? page = null,
        int? size = null
    )
    {
        return _client.Request<List<ComponentGroupMetadata>>(HttpMethod.Get, $"/component-registry/component-groups/{componentGroupReference}/subgroups",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size });
    }

    /// <summary>List the versions of a component.</summary>
    public List<ComponentVersionMetadata> ListComponentVersions(
        string componentReference,
        int? page = null,
        int? size = null
    )
    {
        return _client.Request<List<ComponentVersionMetadata>>(HttpMethod.Get, $"/component-registry/components/{componentReference}/versions",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size });
    }

    /// <summary>List the components in a component group.</summary>
    public List<ComponentOverview> ListComponents(
        string componentGroupReference,
        int? page = null,
        int? size = null,
        string? language = null
    )
    {
        return _client.Request<List<ComponentOverview>>(HttpMethod.Get, $"/component-registry/component-groups/{componentGroupReference}/components",
            queryParams: new Dictionary<string, object?> { ["page"] = page, ["size"] = size, ["language"] = language });
    }
}
