#Get the WorkflowBuildTaskMeta by Name
$WorkflowBuildTaskMetaByName = Get-IntersightWorkflowBuildTaskMeta -Name WorkflowBuildTaskMetaName

#Get the List of ServerProfiles
$WorkflowBuildTaskMetaList = Get-IntersightWorkflowBuildTaskMeta

#Get the list of WorkflowBuildTaskMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowBuildTaskMetaByOrg = Get-IntersightWorkflowBuildTaskMeta -Organization $org

#Get the WorkflowBuildTaskMeta based on query Parameter
$WorkflowBuildTaskMetaByQueryParam = Get-IntersightWorkflowBuildTaskMeta -Filter Name eq WorkflowBuildTaskMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .