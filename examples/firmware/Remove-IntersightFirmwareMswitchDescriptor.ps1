
#Get the FirmwareMswitchDescriptor to delete
$FirmwareMswitchDescriptor = Get-IntersightFirmwareMswitchDescriptor -Name FirmwareMswitchDescriptorName
$FirmwareMswitchDescriptor | Remove-IntersightFirmwareMswitchDescriptor

#Remove the FirmwareMswitchDescriptor by Moid.
Remove-IntersightFirmwareMswitchDescriptor -Moid '<Replace with Moid>'