
#Get the FirmwareMswitchDescriptor to Update
$FirmwareMswitchDescriptor = Get-IntersightFirmwareMswitchDescriptor -Name FirmwareMswitchDescriptorName
$FirmwareMswitchDescriptor | Set-IntersightFirmwareMswitchDescriptor -Description 'Updated description'
