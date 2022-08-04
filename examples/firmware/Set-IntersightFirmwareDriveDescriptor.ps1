
#Get the FirmwareDriveDescriptor to Update
$FirmwareDriveDescriptor = Get-IntersightFirmwareDriveDescriptor -Name FirmwareDriveDescriptorName
$FirmwareDriveDescriptor | Set-IntersightFirmwareDriveDescriptor -Description 'Updated description'
