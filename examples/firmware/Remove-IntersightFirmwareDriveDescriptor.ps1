
#Get the FirmwareDriveDescriptor to delete
$FirmwareDriveDescriptor = Get-IntersightFirmwareDriveDescriptor -Name FirmwareDriveDescriptorName
$FirmwareDriveDescriptor | Remove-IntersightFirmwareDriveDescriptor

#Remove the FirmwareDriveDescriptor by Moid.
Remove-IntersightFirmwareDriveDescriptor -Moid '<Replace with Moid>'
