
#Get the FirmwareGpuDescriptor to delete
$FirmwareGpuDescriptor = Remove-IntersightFirmwareGpuDescriptor -Name FirmwareGpuDescriptorName
$FirmwareGpuDescriptor | Remove-IntersightFirmwareGpuDescriptor

#Remove the server profile by Moid.
Remove-IntersightFirmwareGpuDescriptor -Moid 123bc2222287wee
