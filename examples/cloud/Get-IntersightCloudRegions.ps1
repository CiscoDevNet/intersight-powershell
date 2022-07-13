#Get the CloudRegions by Name
$CloudRegionsByName = Get-IntersightCloudRegions -Name CloudRegionsName

#Get the List of ServerProfiles
$CloudRegionsList = Get-IntersightCloudRegions

#Get the list of CloudRegions under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$CloudRegionsByOrg = Get-IntersightCloudRegions -Organization $org

#Get the CloudRegions based on query Parameter
$CloudRegionsByQueryParam = Get-IntersightCloudRegions -Filter Name eq CloudRegionsName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .