#Get the AssetDeviceConfiguration by Name
$AssetDeviceConfigurationByName = Get-IntersightAssetDeviceConfiguration -Name AssetDeviceConfigurationName

#Get the List of ServerProfiles
$AssetDeviceConfigurationList = Get-IntersightAssetDeviceConfiguration

#Get the list of AssetDeviceConfiguration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$AssetDeviceConfigurationByOrg = Get-IntersightAssetDeviceConfiguration -Organization $org

#Get the AssetDeviceConfiguration based on query Parameter
$AssetDeviceConfigurationByQueryParam = Get-IntersightAssetDeviceConfiguration -Filter Name eq AssetDeviceConfigurationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .