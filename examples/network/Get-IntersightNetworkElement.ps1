#Get the NetworkElement by Name
$NetworkElementByName = Get-IntersightNetworkElement -Name NetworkElementName

#Get the List of ServerProfiles
$NetworkElementList = Get-IntersightNetworkElement

#Get the list of NetworkElement under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NetworkElementByOrg = Get-IntersightNetworkElement -Organization $org

#Get the NetworkElement based on query Parameter
$NetworkElementByQueryParam = Get-IntersightNetworkElement -Filter Name eq NetworkElementName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .