
#Get the DeviceconnectorPolicy to delete
$DeviceconnectorPolicy = Get-IntersightDeviceconnectorPolicy -Name DeviceconnectorPolicyName
$DeviceconnectorPolicy | Remove-IntersightDeviceconnectorPolicy

#Remove the DeviceconnectorPolicy by Moid.
Remove-IntersightDeviceconnectorPolicy -Moid '<Replace with Moid>'
