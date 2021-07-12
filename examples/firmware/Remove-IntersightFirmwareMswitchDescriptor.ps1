
#Get the FirmwareMswitchDescriptor to delete
$FirmwareMswitchDescriptor = Remove-IntersightFirmwareMswitchDescriptor -Name FirmwareMswitchDescriptorName
$FirmwareMswitchDescriptor | Remove-IntersightFirmwareMswitchDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareMswitchDescriptor -Moid 123bc2222287wee
