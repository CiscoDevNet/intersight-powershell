#Get the WorkflowCatalog by Name
$WorkflowCatalogByName = Get-IntersightWorkflowCatalog -Name WorkflowCatalogName

#Get the List of ServerProfiles
$WorkflowCatalogList = Get-IntersightWorkflowCatalog

#Get the list of WorkflowCatalog under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$WorkflowCatalogByOrg = Get-IntersightWorkflowCatalog -Organization $org

#Get the WorkflowCatalog based on query Parameter
$WorkflowCatalogByQueryParam = Get-IntersightWorkflowCatalog -Filter Name eq WorkflowCatalogName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .