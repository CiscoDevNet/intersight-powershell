
#Get the FirmwareCimcDescriptor to Update
$FirmwareCimcDescriptor = Get-IntersightFirmwareCimcDescriptor -Name FirmwareCimcDescriptorName
$FirmwareCimcDescriptor | Set-IntersightFirmwareCimcDescriptor -Description 'Updated description'
