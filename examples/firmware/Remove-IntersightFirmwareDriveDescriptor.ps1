
#Get the FirmwareDriveDescriptor to delete
$FirmwareDriveDescriptor = Remove-IntersightFirmwareDriveDescriptor -Name FirmwareDriveDescriptorName
$FirmwareDriveDescriptor | Remove-IntersightFirmwareDriveDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareDriveDescriptor -Moid 123bc2222287wee
