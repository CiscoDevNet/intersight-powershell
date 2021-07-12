
#Get the FirmwareSasExpanderDescriptor to delete
$FirmwareSasExpanderDescriptor = Remove-IntersightFirmwareSasExpanderDescriptor -Name FirmwareSasExpanderDescriptorName
$FirmwareSasExpanderDescriptor | Remove-IntersightFirmwareSasExpanderDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareSasExpanderDescriptor -Moid 123bc2222287wee
