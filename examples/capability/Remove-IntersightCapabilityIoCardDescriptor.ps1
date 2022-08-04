
#Get the CapabilityIoCardDescriptor to delete
$CapabilityIoCardDescriptor = Get-IntersightCapabilityIoCardDescriptor -Name CapabilityIoCardDescriptorName
$CapabilityIoCardDescriptor | Remove-IntersightCapabilityIoCardDescriptor

#Remove the CapabilityIoCardDescriptor by Moid.
Remove-IntersightCapabilityIoCardDescriptor -Moid '<Replace with Moid>'
