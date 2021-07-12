#Get the CloudSkuVolumeType by Name
$CloudSkuVolumeTypeByName = Get-IntersightCloudSkuVolumeType -Name CloudSkuVolumeTypeName

#Get the List of ServerProfiles
$CloudSkuVolumeTypeList = Get-IntersightCloudSkuVolumeType

#Get the list of CloudSkuVolumeType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CloudSkuVolumeTypeByOrg = Get-IntersightCloudSkuVolumeType -Organization $org

#Get the CloudSkuVolumeType based on query Parameter
$CloudSkuVolumeTypeByQueryParam = Get-IntersightCloudSkuVolumeType -Filter Name eq CloudSkuVolumeTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .