
#Get the FirmwareHbaDescriptor to Update
$FirmwareHbaDescriptor = Get-IntersightFirmwareHbaDescriptor -Name FirmwareHbaDescriptorName
$FirmwareHbaDescriptor | Set-IntersightFirmwareHbaDescriptor -Description 'Updated description'
