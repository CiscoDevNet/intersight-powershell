#Get the HyperflexHxapHost by Name
$HyperflexHxapHostByName = Get-IntersightHyperflexHxapHost -Name HyperflexHxapHostName

#Get the List of ServerProfiles
$HyperflexHxapHostList = Get-IntersightHyperflexHxapHost

#Get the list of HyperflexHxapHost under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapHostByOrg = Get-IntersightHyperflexHxapHost -Organization $org

#Get the HyperflexHxapHost based on query Parameter
$HyperflexHxapHostByQueryParam = Get-IntersightHyperflexHxapHost -Filter Name eq HyperflexHxapHostName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .