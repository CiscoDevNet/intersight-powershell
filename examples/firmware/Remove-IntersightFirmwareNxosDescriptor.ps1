
#Get the FirmwareNxosDescriptor to delete
$FirmwareNxosDescriptor = Remove-IntersightFirmwareNxosDescriptor -Name FirmwareNxosDescriptorName
$FirmwareNxosDescriptor | Remove-IntersightFirmwareNxosDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareNxosDescriptor -Moid 123bc2222287wee
