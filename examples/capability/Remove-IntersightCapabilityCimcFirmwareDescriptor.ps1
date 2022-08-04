
#Get the CapabilityCimcFirmwareDescriptor to delete
$CapabilityCimcFirmwareDescriptor = Get-IntersightCapabilityCimcFirmwareDescriptor -Name CapabilityCimcFirmwareDescriptorName
$CapabilityCimcFirmwareDescriptor | Remove-IntersightCapabilityCimcFirmwareDescriptor

#Remove the CapabilityCimcFirmwareDescriptor by Moid.
Remove-IntersightCapabilityCimcFirmwareDescriptor -Moid '<Replace with Moid>'
