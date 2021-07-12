
#Get the CapabilitySwitchDescriptor to delete
$CapabilitySwitchDescriptor = Remove-IntersightCapabilitySwitchDescriptor -Name CapabilitySwitchDescriptorName
$CapabilitySwitchDescriptor | Remove-IntersightCapabilitySwitchDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilitySwitchDescriptor -Moid 123bc2222287wee
