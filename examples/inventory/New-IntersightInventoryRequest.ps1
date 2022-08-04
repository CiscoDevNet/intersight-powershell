$device1 = Initialize-IntersightAssetDeviceRegistration -AccessKeyId 9 -ExecutionMode ContainerEmulator -PlatformType AmazonWebService

$inventory = New-IntersightInventoryRequest -Device $device1 