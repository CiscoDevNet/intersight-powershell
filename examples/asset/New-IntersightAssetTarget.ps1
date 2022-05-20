$account1 = Get-IntersightIamaccount -Moid '<Replace with Moid>'

$registered_device1 = Initialize-IntersightAssetDeviceRegistration -Moid '<Replace with Moid>'

$connection = Initialize-IntersightAssetConnection

$asset_target1 = New-IntersightAssetTarget -Account $account1 -RegisteredDevice $registered_device1 -Connections $connection -Name 'C240-WZP21330QS5' -Status 'NotConnected' -TargetType 'IMCM5'