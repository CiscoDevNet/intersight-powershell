
#Get the FirmwareHbaDescriptor to delete
$FirmwareHbaDescriptor = Get-IntersightFirmwareHbaDescriptor -Name FirmwareHbaDescriptorName
$FirmwareHbaDescriptor | Remove-IntersightFirmwareHbaDescriptor

#Remove the FirmwareHbaDescriptor by Moid.
Remove-IntersightFirmwareHbaDescriptor -Moid '<Replace with Moid>'
