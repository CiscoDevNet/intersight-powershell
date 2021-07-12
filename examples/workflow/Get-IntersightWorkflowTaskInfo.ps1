#Get the WorkflowTaskInfo by Name
$WorkflowTaskInfoByName = Get-IntersightWorkflowTaskInfo -Name WorkflowTaskInfoName

#Get the List of ServerProfiles
$WorkflowTaskInfoList = Get-IntersightWorkflowTaskInfo

#Get the list of WorkflowTaskInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowTaskInfoByOrg = Get-IntersightWorkflowTaskInfo -Organization $org

#Get the WorkflowTaskInfo based on query Parameter
$WorkflowTaskInfoByQueryParam = Get-IntersightWorkflowTaskInfo -Filter Name eq WorkflowTaskInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .