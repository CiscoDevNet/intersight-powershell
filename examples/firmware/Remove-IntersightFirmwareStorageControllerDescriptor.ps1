
#Get the FirmwareStorageControllerDescriptor to delete
$FirmwareStorageControllerDescriptor = Remove-IntersightFirmwareStorageControllerDescriptor -Name FirmwareStorageControllerDescriptorName
$FirmwareStorageControllerDescriptor | Remove-IntersightFirmwareStorageControllerDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareStorageControllerDescriptor -Moid 123bc2222287wee
