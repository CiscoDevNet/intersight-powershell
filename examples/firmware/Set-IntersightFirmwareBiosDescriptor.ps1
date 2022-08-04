
#Get the FirmwareBiosDescriptor to Update
$FirmwareBiosDescriptor = Get-IntersightFirmwareBiosDescriptor -Name FirmwareBiosDescriptorName
$FirmwareBiosDescriptor | Set-IntersightFirmwareBiosDescriptor -Description 'Updated description'
