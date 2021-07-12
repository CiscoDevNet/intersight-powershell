
#Get the CapabilityChassisDescriptor to delete
$CapabilityChassisDescriptor = Remove-IntersightCapabilityChassisDescriptor -Name CapabilityChassisDescriptorName
$CapabilityChassisDescriptor | Remove-IntersightCapabilityChassisDescriptor

#Remove the server profile by Moid.
Remove-IntersightCapabilityChassisDescriptor -Moid 123bc2222287wee
