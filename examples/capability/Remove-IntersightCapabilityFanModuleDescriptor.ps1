
#Get the CapabilityFanModuleDescriptor to delete
$CapabilityFanModuleDescriptor = Remove-IntersightCapabilityFanModuleDescriptor -Name CapabilityFanModuleDescriptorName
$CapabilityFanModuleDescriptor | Remove-IntersightCapabilityFanModuleDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilityFanModuleDescriptor -Moid 123bc2222287wee
