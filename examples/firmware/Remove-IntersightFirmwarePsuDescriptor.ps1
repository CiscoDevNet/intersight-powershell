
#Get the FirmwarePsuDescriptor to delete
$FirmwarePsuDescriptor = Remove-IntersightFirmwarePsuDescriptor -Name FirmwarePsuDescriptorName
$FirmwarePsuDescriptor | Remove-IntersightFirmwarePsuDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwarePsuDescriptor -Moid 123bc2222287wee
