
#Get the DeviceconnectorPolicy to delete
$DeviceconnectorPolicy = Remove-IntersightDeviceconnectorPolicy -Name DeviceconnectorPolicyName
$DeviceconnectorPolicy | Remove-IntersightDeviceconnectorPolicy

#Remove the server profile by Moid.
Remove-IntersightDeviceconnectorPolicy -Moid 123bc2222287wee
