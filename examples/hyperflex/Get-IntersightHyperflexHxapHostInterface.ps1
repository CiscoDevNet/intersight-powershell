#Get the HyperflexHxapHostInterface by Name
$HyperflexHxapHostInterfaceByName = Get-IntersightHyperflexHxapHostInterface -Name HyperflexHxapHostInterfaceName

#Get the List of ServerProfiles
$HyperflexHxapHostInterfaceList = Get-IntersightHyperflexHxapHostInterface

#Get the list of HyperflexHxapHostInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexHxapHostInterfaceByOrg = Get-IntersightHyperflexHxapHostInterface -Organization $org

#Get the HyperflexHxapHostInterface based on query Parameter
$HyperflexHxapHostInterfaceByQueryParam = Get-IntersightHyperflexHxapHostInterface -Filter Name eq HyperflexHxapHostInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .