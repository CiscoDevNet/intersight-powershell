#Get the HyperflexHxapNetwork by Name
$HyperflexHxapNetworkByName = Get-IntersightHyperflexHxapNetwork -Name HyperflexHxapNetworkName

#Get the List of ServerProfiles
$HyperflexHxapNetworkList = Get-IntersightHyperflexHxapNetwork

#Get the list of HyperflexHxapNetwork under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHxapNetworkByOrg = Get-IntersightHyperflexHxapNetwork -Organization $org

#Get the HyperflexHxapNetwork based on query Parameter
$HyperflexHxapNetworkByQueryParam = Get-IntersightHyperflexHxapNetwork -Filter Name eq HyperflexHxapNetworkName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .