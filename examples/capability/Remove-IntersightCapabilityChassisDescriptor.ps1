
#Get the CapabilityChassisDescriptor to delete
$CapabilityChassisDescriptor = Get-IntersightCapabilityChassisDescriptor -Name CapabilityChassisDescriptorName
$CapabilityChassisDescriptor | Remove-IntersightCapabilityChassisDescriptor

#Remove the CapabilityChassisDescriptor by Moid.
Remove-IntersightCapabilityChassisDescriptor -Moid '<Replace with Moid>'
