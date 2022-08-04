
#Get the CapabilityIoCardDescriptor to Update
$CapabilityIoCardDescriptor = Get-IntersightCapabilityIoCardDescriptor -Name CapabilityIoCardDescriptorName
$CapabilityIoCardDescriptor | Set-IntersightCapabilityIoCardDescriptor -Description 'Updated description'