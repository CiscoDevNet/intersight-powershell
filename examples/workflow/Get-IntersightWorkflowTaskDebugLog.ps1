#Get the WorkflowTaskDebugLog by Name
$WorkflowTaskDebugLogByName = Get-IntersightWorkflowTaskDebugLog -Name WorkflowTaskDebugLogName

#Get the List of ServerProfiles
$WorkflowTaskDebugLogList = Get-IntersightWorkflowTaskDebugLog

#Get the list of WorkflowTaskDebugLog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowTaskDebugLogByOrg = Get-IntersightWorkflowTaskDebugLog -Organization $org

#Get the WorkflowTaskDebugLog based on query Parameter
$WorkflowTaskDebugLogByQueryParam = Get-IntersightWorkflowTaskDebugLog -Filter Name eq WorkflowTaskDebugLogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .