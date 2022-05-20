
#Get the FirmwarePsuDescriptor to Update
$FirmwarePsuDescriptor = Get-IntersightFirmwarePsuDescriptor -Name FirmwarePsuDescriptorName
$FirmwarePsuDescriptor | Set-IntersightFirmwarePsuDescriptor -Description 'Updated description'
