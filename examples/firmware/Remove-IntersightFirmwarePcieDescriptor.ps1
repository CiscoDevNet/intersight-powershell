
#Get the FirmwarePcieDescriptor to delete
$FirmwarePcieDescriptor = Get-IntersightFirmwarePcieDescriptor -Name FirmwarePcieDescriptorName
$FirmwarePcieDescriptor | Remove-IntersightFirmwarePcieDescriptor

#Remove the FirmwarePcieDescriptor by Moid.
Remove-IntersightFirmwarePcieDescriptor -Moid '<Replace with Moid>'
