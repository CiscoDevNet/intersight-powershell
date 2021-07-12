
#Get the FirmwareDimmDescriptor to delete
$FirmwareDimmDescriptor = Remove-IntersightFirmwareDimmDescriptor -Name FirmwareDimmDescriptorName
$FirmwareDimmDescriptor | Remove-IntersightFirmwareDimmDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareDimmDescriptor -Moid 123bc2222287wee
