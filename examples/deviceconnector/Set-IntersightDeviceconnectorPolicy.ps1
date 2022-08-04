
#Get the DeviceconnectorPolicy to Update
$DeviceconnectorPolicy = Get-IntersightDeviceconnectorPolicy -Name DeviceconnectorPolicyName
$DeviceconnectorPolicy | Set-IntersightDeviceconnectorPolicy -Description 'Updated description'