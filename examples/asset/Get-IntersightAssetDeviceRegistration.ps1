#Get the AssetDeviceRegistration by Name
$AssetDeviceRegistrationByName = Get-IntersightAssetDeviceRegistration -Name AssetDeviceRegistrationName

#Get the List of ServerProfiles
$AssetDeviceRegistrationList = Get-IntersightAssetDeviceRegistration

#Get the list of AssetDeviceRegistration under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$AssetDeviceRegistrationByOrg = Get-IntersightAssetDeviceRegistration -Organization $org

#Get the AssetDeviceRegistration based on query Parameter
$AssetDeviceRegistrationByQueryParam = Get-IntersightAssetDeviceRegistration -Filter Name eq AssetDeviceRegistrationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .