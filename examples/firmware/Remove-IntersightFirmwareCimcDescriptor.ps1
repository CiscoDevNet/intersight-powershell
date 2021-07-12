
#Get the FirmwareCimcDescriptor to delete
$FirmwareCimcDescriptor = Remove-IntersightFirmwareCimcDescriptor -Name FirmwareCimcDescriptorName
$FirmwareCimcDescriptor | Remove-IntersightFirmwareCimcDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareCimcDescriptor -Moid 123bc2222287wee
