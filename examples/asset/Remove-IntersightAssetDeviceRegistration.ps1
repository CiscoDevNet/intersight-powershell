
#Get the AssetDeviceRegistration to delete
$AssetDeviceRegistration = Remove-IntersightAssetDeviceRegistration -Name AssetDeviceRegistrationName
$AssetDeviceRegistration | Remove-IntersightAssetDeviceRegistration

#Remove the server profile by Moid.
Remove-IntersightAssetDeviceRegistration -Moid 123bc2222287wee
