#Get the HyperflexHealthCheckExecution by Name
$HyperflexHealthCheckExecutionByName = Get-IntersightHyperflexHealthCheckExecution -Name HyperflexHealthCheckExecutionName

#Get the List of ServerProfiles
$HyperflexHealthCheckExecutionList = Get-IntersightHyperflexHealthCheckExecution

#Get the list of HyperflexHealthCheckExecution under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHealthCheckExecutionByOrg = Get-IntersightHyperflexHealthCheckExecution -Organization $org

#Get the HyperflexHealthCheckExecution based on query Parameter
$HyperflexHealthCheckExecutionByQueryParam = Get-IntersightHyperflexHealthCheckExecution -Filter Name eq HyperflexHealthCheckExecutionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .