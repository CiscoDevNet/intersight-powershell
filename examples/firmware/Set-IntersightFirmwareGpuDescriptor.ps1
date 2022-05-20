
#Get the FirmwareGpuDescriptor to Update
$FirmwareGpuDescriptor = Get-IntersightFirmwareGpuDescriptor -Name FirmwareGpuDescriptorName
$FirmwareGpuDescriptor | Set-IntersightFirmwareGpuDescriptor -Description 'Updated description'
