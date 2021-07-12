
#Get the FirmwarePcieDescriptor to delete
$FirmwarePcieDescriptor = Remove-IntersightFirmwarePcieDescriptor -Name FirmwarePcieDescriptorName
$FirmwarePcieDescriptor | Remove-IntersightFirmwarePcieDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwarePcieDescriptor -Moid 123bc2222287wee
