#Get the WorkflowWorkflowMeta by Name
$WorkflowWorkflowMetaByName = Get-IntersightWorkflowWorkflowMeta -Name WorkflowWorkflowMetaName

#Get the List of ServerProfiles
$WorkflowWorkflowMetaList = Get-IntersightWorkflowWorkflowMeta

#Get the list of WorkflowWorkflowMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowWorkflowMetaByOrg = Get-IntersightWorkflowWorkflowMeta -Organization $org

#Get the WorkflowWorkflowMeta based on query Parameter
$WorkflowWorkflowMetaByQueryParam = Get-IntersightWorkflowWorkflowMeta -Filter Name eq WorkflowWorkflowMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .