
#Get the FirmwareHbaDescriptor to delete
$FirmwareHbaDescriptor = Remove-IntersightFirmwareHbaDescriptor -Name FirmwareHbaDescriptorName
$FirmwareHbaDescriptor | Remove-IntersightFirmwareHbaDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareHbaDescriptor -Moid 123bc2222287wee
