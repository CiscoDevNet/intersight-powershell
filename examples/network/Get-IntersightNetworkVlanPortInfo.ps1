#Get the NetworkVlanPortInfo by Name
$NetworkVlanPortInfoByName = Get-IntersightNetworkVlanPortInfo -Name NetworkVlanPortInfoName

#Get the List of ServerProfiles
$NetworkVlanPortInfoList = Get-IntersightNetworkVlanPortInfo

#Get the list of NetworkVlanPortInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NetworkVlanPortInfoByOrg = Get-IntersightNetworkVlanPortInfo -Organization $org

#Get the NetworkVlanPortInfo based on query Parameter
$NetworkVlanPortInfoByQueryParam = Get-IntersightNetworkVlanPortInfo -Filter Name eq NetworkVlanPortInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .