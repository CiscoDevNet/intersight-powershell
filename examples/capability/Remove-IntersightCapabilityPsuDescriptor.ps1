
#Get the CapabilityPsuDescriptor to delete
$CapabilityPsuDescriptor = Remove-IntersightCapabilityPsuDescriptor -Name CapabilityPsuDescriptorName
$CapabilityPsuDescriptor | Remove-IntersightCapabilityPsuDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilityPsuDescriptor -Moid 123bc2222287wee
