#Get the HyperflexConfigResult by Name
$HyperflexConfigResultByName = Get-IntersightHyperflexConfigResult -Name HyperflexConfigResultName

#Get the List of ServerProfiles
$HyperflexConfigResultList = Get-IntersightHyperflexConfigResult

#Get the list of HyperflexConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexConfigResultByOrg = Get-IntersightHyperflexConfigResult -Organization $org

#Get the HyperflexConfigResult based on query Parameter
$HyperflexConfigResultByQueryParam = Get-IntersightHyperflexConfigResult -Filter Name eq HyperflexConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .