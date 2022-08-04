
#Get the CapabilityAdapterUnitDescriptor to delete
$CapabilityAdapterUnitDescriptor = Get-IntersightCapabilityAdapterUnitDescriptor -Name CapabilityAdapterUnitDescriptorName
$CapabilityAdapterUnitDescriptor | Remove-IntersightCapabilityAdapterUnitDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilityAdapterUnitDescriptor -Moid '<Replace with Moid>'
