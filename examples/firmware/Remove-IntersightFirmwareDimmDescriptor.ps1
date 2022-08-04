
#Get the FirmwareDimmDescriptor to delete
$FirmwareDimmDescriptor = Get-IntersightFirmwareDimmDescriptor -Name FirmwareDimmDescriptorName
$FirmwareDimmDescriptor | Remove-IntersightFirmwareDimmDescriptor

#Remove the FirmwareDimmDescriptor by Moid.
Remove-IntersightFirmwareDimmDescriptor -Moid '<Replace with Moid>'
