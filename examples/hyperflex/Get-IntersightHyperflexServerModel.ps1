#Get the HyperflexServerModel by Name
$HyperflexServerModelByName = Get-IntersightHyperflexServerModel -Name HyperflexServerModelName

#Get the List of ServerProfiles
$HyperflexServerModelList = Get-IntersightHyperflexServerModel

#Get the list of HyperflexServerModel under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexServerModelByOrg = Get-IntersightHyperflexServerModel -Organization $org

#Get the HyperflexServerModel based on query Parameter
$HyperflexServerModelByQueryParam = Get-IntersightHyperflexServerModel -Filter Name eq HyperflexServerModelName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .