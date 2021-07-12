
#Get the FirmwareIomDescriptor to delete
$FirmwareIomDescriptor = Remove-IntersightFirmwareIomDescriptor -Name FirmwareIomDescriptorName
$FirmwareIomDescriptor | Remove-IntersightFirmwareIomDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareIomDescriptor -Moid 123bc2222287wee
