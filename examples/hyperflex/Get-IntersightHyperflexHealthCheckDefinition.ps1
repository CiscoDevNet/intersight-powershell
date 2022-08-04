#Get the HyperflexHealthCheckDefinition by Name
$HyperflexHealthCheckDefinitionByName = Get-IntersightHyperflexHealthCheckDefinition -Name HyperflexHealthCheckDefinitionName

#Get the List of ServerProfiles
$HyperflexHealthCheckDefinitionList = Get-IntersightHyperflexHealthCheckDefinition

#Get the list of HyperflexHealthCheckDefinition under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHealthCheckDefinitionByOrg = Get-IntersightHyperflexHealthCheckDefinition -Organization $org

#Get the HyperflexHealthCheckDefinition based on query Parameter
$HyperflexHealthCheckDefinitionByQueryParam = Get-IntersightHyperflexHealthCheckDefinition -Filter Name eq HyperflexHealthCheckDefinitionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .