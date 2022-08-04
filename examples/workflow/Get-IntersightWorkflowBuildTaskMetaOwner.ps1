#Get the WorkflowBuildTaskMetaOwner by Name
$WorkflowBuildTaskMetaOwnerByName = Get-IntersightWorkflowBuildTaskMetaOwner -Name WorkflowBuildTaskMetaOwnerName

#Get the List of ServerProfiles
$WorkflowBuildTaskMetaOwnerList = Get-IntersightWorkflowBuildTaskMetaOwner

#Get the list of WorkflowBuildTaskMetaOwner under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowBuildTaskMetaOwnerByOrg = Get-IntersightWorkflowBuildTaskMetaOwner -Organization $org

#Get the WorkflowBuildTaskMetaOwner based on query Parameter
$WorkflowBuildTaskMetaOwnerByQueryParam = Get-IntersightWorkflowBuildTaskMetaOwner -Filter Name eq WorkflowBuildTaskMetaOwnerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .