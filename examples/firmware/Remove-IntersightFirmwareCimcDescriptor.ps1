
#Get the FirmwareCimcDescriptor to delete
$FirmwareCimcDescriptor = Get-IntersightFirmwareCimcDescriptor -Name FirmwareCimcDescriptorName
$FirmwareCimcDescriptor | Remove-IntersightFirmwareCimcDescriptor

#Remove the FirmwareCimcDescriptor by Moid.
Remove-IntersightFirmwareCimcDescriptor -Moid '<Replace with Moid>'
