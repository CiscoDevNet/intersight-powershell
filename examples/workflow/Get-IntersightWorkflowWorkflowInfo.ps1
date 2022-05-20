#Get the WorkflowWorkflowInfo by Name
$WorkflowWorkflowInfoByName = Get-IntersightWorkflowWorkflowInfo -Name WorkflowWorkflowInfoName

#Get the List of WorkflowWorkflowInfo
$WorkflowWorkflowInfoList = Get-IntersightWorkflowWorkflowInfo

#Get the list of WorkflowWorkflowInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowWorkflowInfoByOrg = Get-IntersightWorkflowWorkflowInfo -Organization $org

#Get the WorkflowWorkflowInfo based on query Parameter
$WorkflowWorkflowInfoByQueryParam = Get-IntersightWorkflowWorkflowInfo -Filter Name eq WorkflowWorkflowInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .