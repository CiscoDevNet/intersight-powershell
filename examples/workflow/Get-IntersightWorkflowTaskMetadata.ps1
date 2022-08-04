#Get the WorkflowTaskMetadata by Name
$WorkflowTaskMetadataByName = Get-IntersightWorkflowTaskMetadata -Name WorkflowTaskMetadataName

#Get the List of ServerProfiles
$WorkflowTaskMetadataList = Get-IntersightWorkflowTaskMetadata

#Get the list of WorkflowTaskMetadata under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowTaskMetadataByOrg = Get-IntersightWorkflowTaskMetadata -Organization $org

#Get the WorkflowTaskMetadata based on query Parameter
$WorkflowTaskMetadataByQueryParam = Get-IntersightWorkflowTaskMetadata -Filter Name eq WorkflowTaskMetadataName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .