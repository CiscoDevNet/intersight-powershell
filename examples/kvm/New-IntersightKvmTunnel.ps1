$device1 = Get-IntersightAssetDeviceregistration -Moid '<Replace with Moid>'

$server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'

$kvm_tunnel1 = New-IntersightKvmTunnel -Device $device1 -Server $server1