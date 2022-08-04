
#Get the FirmwareSasExpanderDescriptor to delete
$FirmwareSasExpanderDescriptor = Get-IntersightFirmwareSasExpanderDescriptor -Name FirmwareSasExpanderDescriptorName
$FirmwareSasExpanderDescriptor | Remove-IntersightFirmwareSasExpanderDescriptor

#Remove the FirmwareSasExpanderDescriptor by Moid.
Remove-IntersightFirmwareSasExpanderDescriptor -Moid '<Replace with Moid>'
