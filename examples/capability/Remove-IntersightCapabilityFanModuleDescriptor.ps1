
#Get the CapabilityFanModuleDescriptor to delete
$CapabilityFanModuleDescriptor = Get-IntersightCapabilityFanModuleDescriptor -Name CapabilityFanModuleDescriptorName
$CapabilityFanModuleDescriptor | Remove-IntersightCapabilityFanModuleDescriptor

#Remove the CapabilityFanModuleDescriptor by Moid.
Remove-IntersightCapabilityFanModuleDescriptor -Moid '<Replace with Moid>'
