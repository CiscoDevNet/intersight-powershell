
#Get the FirmwareIomDescriptor to delete
$FirmwareIomDescriptor = Get-IntersightFirmwareIomDescriptor -Name FirmwareIomDescriptorName
$FirmwareIomDescriptor | Remove-IntersightFirmwareIomDescriptor

#Remove the FirmwareIomDescriptor by Moid.
Remove-IntersightFirmwareIomDescriptor -Moid '<Replace with Moid>'
