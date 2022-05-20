
#Get the FirmwareBoardControllerDescriptor to delete
$FirmwareBoardControllerDescriptor = Get-IntersightFirmwareBoardControllerDescriptor -Name FirmwareBoardControllerDescriptorName
$FirmwareBoardControllerDescriptor | Remove-IntersightFirmwareBoardControllerDescriptor

#Remove the FirmwareBoardControllerDescriptor by Moid.
Remove-IntersightFirmwareBoardControllerDescriptor -Moid '<Replace with Moid>'
