#Get the WorkflowPendingDynamicWorkflowInfo by Name
$WorkflowPendingDynamicWorkflowInfoByName = Get-IntersightWorkflowPendingDynamicWorkflowInfo -Name WorkflowPendingDynamicWorkflowInfoName

#Get the List of ServerProfiles
$WorkflowPendingDynamicWorkflowInfoList = Get-IntersightWorkflowPendingDynamicWorkflowInfo

#Get the list of WorkflowPendingDynamicWorkflowInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$WorkflowPendingDynamicWorkflowInfoByOrg = Get-IntersightWorkflowPendingDynamicWorkflowInfo -Organization $org

#Get the WorkflowPendingDynamicWorkflowInfo based on query Parameter
$WorkflowPendingDynamicWorkflowInfoByQueryParam = Get-IntersightWorkflowPendingDynamicWorkflowInfo -Filter Name eq WorkflowPendingDynamicWorkflowInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .