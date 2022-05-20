
#Get the FirmwareDimmDescriptor to Update
$FirmwareDimmDescriptor = Get-IntersightFirmwareDimmDescriptor -Name FirmwareDimmDescriptorName
$FirmwareDimmDescriptor | Set-IntersightFirmwareDimmDescriptor -Description 'Updated description'
