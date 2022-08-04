
#Get the CapabilitySwitchDescriptor to delete
$CapabilitySwitchDescriptor = Get-IntersightCapabilitySwitchDescriptor -Name CapabilitySwitchDescriptorName
$CapabilitySwitchDescriptor | Remove-IntersightCapabilitySwitchDescriptor

#Remove the CapabilitySwitchDescriptor by Moid.
Remove-IntersightCapabilitySwitchDescriptor -Moid '<Replace with Moid>'
