
#Get the CapabilityPsuDescriptor to delete
$CapabilityPsuDescriptor = Get-IntersightCapabilityPsuDescriptor -Name CapabilityPsuDescriptorName
$CapabilityPsuDescriptor | Remove-IntersightCapabilityPsuDescriptor

#Remove the CapabilityPsuDescriptor by Moid.
Remove-IntersightCapabilityPsuDescriptor -Moid '<Replace with Moid>'
