#Get the WorkflowWorkflowMetadata by Name
$WorkflowWorkflowMetadataByName = Get-IntersightWorkflowWorkflowMetadata -Name WorkflowWorkflowMetadataName

#Get the List of ServerProfiles
$WorkflowWorkflowMetadataList = Get-IntersightWorkflowWorkflowMetadata

#Get the list of WorkflowWorkflowMetadata under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowWorkflowMetadataByOrg = Get-IntersightWorkflowWorkflowMetadata -Organization $org

#Get the WorkflowWorkflowMetadata based on query Parameter
$WorkflowWorkflowMetadataByQueryParam = Get-IntersightWorkflowWorkflowMetadata -Filter Name eq WorkflowWorkflowMetadataName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .