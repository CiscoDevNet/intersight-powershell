$device1 = Get-IntersightAssetDeviceregistration -Moid '<Replace with Moid>'

$server1 = Get-IntersightComputeRackunit -Moid '<Replace with Moid>'

$tunnel1 = Get-IntersightKvmTunnel -Moid '<Replace with Moid>'

$kvm_session1 = New-IntersightKvmSession -Device $device1 -Server $server1 -Tunnel $tunnel1