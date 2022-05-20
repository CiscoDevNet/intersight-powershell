
#Get the CapabilityChassisDescriptor to Update
$CapabilityChassisDescriptor = Get-IntersightCapabilityChassisDescriptor -Name CapabilityChassisDescriptorName
$CapabilityChassisDescriptor | Set-IntersightCapabilityChassisDescriptor -Description 'Updated description'