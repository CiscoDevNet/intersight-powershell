#Get the NetworkFcZoneInfo by Name
$NetworkFcZoneInfoByName = Get-IntersightNetworkFcZoneInfo -Name NetworkFcZoneInfoName

#Get the List of ServerProfiles
$NetworkFcZoneInfoList = Get-IntersightNetworkFcZoneInfo

#Get the list of NetworkFcZoneInfo under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$NetworkFcZoneInfoByOrg = Get-IntersightNetworkFcZoneInfo -Organization $org

#Get the NetworkFcZoneInfo based on query Parameter
$NetworkFcZoneInfoByQueryParam = Get-IntersightNetworkFcZoneInfo -Filter Name eq NetworkFcZoneInfoName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .