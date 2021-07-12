#Get the AssetDeviceConnectorManager by Name
$AssetDeviceConnectorManagerByName = Get-IntersightAssetDeviceConnectorManager -Name AssetDeviceConnectorManagerName

#Get the List of ServerProfiles
$AssetDeviceConnectorManagerList = Get-IntersightAssetDeviceConnectorManager

#Get the list of AssetDeviceConnectorManager under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AssetDeviceConnectorManagerByOrg = Get-IntersightAssetDeviceConnectorManager -Organization $org

#Get the AssetDeviceConnectorManager based on query Parameter
$AssetDeviceConnectorManagerByQueryParam = Get-IntersightAssetDeviceConnectorManager -Filter Name eq AssetDeviceConnectorManagerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .