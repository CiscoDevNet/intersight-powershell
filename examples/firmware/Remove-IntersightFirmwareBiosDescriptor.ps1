
#Get the FirmwareBiosDescriptor to delete
$FirmwareBiosDescriptor = Remove-IntersightFirmwareBiosDescriptor -Name FirmwareBiosDescriptorName
$FirmwareBiosDescriptor | Remove-IntersightFirmwareBiosDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareBiosDescriptor -Moid 123bc2222287wee
