#Get the WorkflowTemplateFunctionMeta by Name
$WorkflowTemplateFunctionMetaByName = Get-IntersightWorkflowTemplateFunctionMeta -Name WorkflowTemplateFunctionMetaName

#Get the List of ServerProfiles
$WorkflowTemplateFunctionMetaList = Get-IntersightWorkflowTemplateFunctionMeta

#Get the list of WorkflowTemplateFunctionMeta under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowTemplateFunctionMetaByOrg = Get-IntersightWorkflowTemplateFunctionMeta -Organization $org

#Get the WorkflowTemplateFunctionMeta based on query Parameter
$WorkflowTemplateFunctionMetaByQueryParam = Get-IntersightWorkflowTemplateFunctionMeta -Filter Name eq WorkflowTemplateFunctionMetaName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .