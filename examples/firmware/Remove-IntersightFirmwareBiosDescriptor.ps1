
#Get the FirmwareBiosDescriptor to delete
$FirmwareBiosDescriptor = Get-IntersightFirmwareBiosDescriptor -Name FirmwareBiosDescriptorName
$FirmwareBiosDescriptor | Remove-IntersightFirmwareBiosDescriptor

#Remove the FirmwareBiosDescriptor by Moid.
Remove-IntersightFirmwareBiosDescriptor -Moid '<Replace with Moid>'
