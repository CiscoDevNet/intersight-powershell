
#Get the FirmwareNxosDescriptor to delete
$FirmwareNxosDescriptor = Get-IntersightFirmwareNxosDescriptor -Name FirmwareNxosDescriptorName
$FirmwareNxosDescriptor | Remove-IntersightFirmwareNxosDescriptor

#Remove the FirmwareNxosDescriptor by Moid.
Remove-IntersightFirmwareNxosDescriptor -Moid '<Replace with Moid>'
