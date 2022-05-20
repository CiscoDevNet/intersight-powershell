
#Get the FirmwareIomDescriptor to Update
$FirmwareIomDescriptor = Get-IntersightFirmwareIomDescriptor -Name FirmwareIomDescriptorName
$FirmwareIomDescriptor | Set-IntersightFirmwareIomDescriptor -Description 'Updated description'
