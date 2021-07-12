
#Get the CapabilityIoCardDescriptor to delete
$CapabilityIoCardDescriptor = Remove-IntersightCapabilityIoCardDescriptor -Name CapabilityIoCardDescriptorName
$CapabilityIoCardDescriptor | Remove-IntersightCapabilityIoCardDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilityIoCardDescriptor -Moid 123bc2222287wee
