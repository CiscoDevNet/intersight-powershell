
#Get the FirmwarePcieDescriptor to Update
$FirmwarePcieDescriptor = Get-IntersightFirmwarePcieDescriptor -Name FirmwarePcieDescriptorName
$FirmwarePcieDescriptor | Set-IntersightFirmwarePcieDescriptor -Description 'Updated description'
