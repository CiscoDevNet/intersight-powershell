
#Get the FirmwarePsuDescriptor to delete
$FirmwarePsuDescriptor = Get-IntersightFirmwarePsuDescriptor -Name FirmwarePsuDescriptorName
$FirmwarePsuDescriptor | Remove-IntersightFirmwarePsuDescriptor

#Remove the FirmwarePsuDescriptor by Moid.
Remove-IntersightFirmwarePsuDescriptor -Moid '<Replace with Moid>'
