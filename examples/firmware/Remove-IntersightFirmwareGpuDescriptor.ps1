
#Get the FirmwareGpuDescriptor to delete
$FirmwareGpuDescriptor = Get-IntersightFirmwareGpuDescriptor -Name FirmwareGpuDescriptorName
$FirmwareGpuDescriptor | Remove-IntersightFirmwareGpuDescriptor

#Remove the FirmwareGpuDescriptor by Moid.
Remove-IntersightFirmwareGpuDescriptor -Moid '<Replace with Moid>'
