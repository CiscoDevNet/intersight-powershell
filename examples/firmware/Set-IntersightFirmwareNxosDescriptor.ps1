
#Get the FirmwareNxosDescriptor to Update
$FirmwareNxosDescriptor = Get-IntersightFirmwareNxosDescriptor -Name FirmwareNxosDescriptorName
$FirmwareNxosDescriptor | Set-IntersightFirmwareNxosDescriptor -Description 'Updated description'
