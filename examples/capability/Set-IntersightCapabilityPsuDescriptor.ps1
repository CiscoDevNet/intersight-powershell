
#Get the CapabilityPsuDescriptor to Update
$CapabilityPsuDescriptor = Get-IntersightCapabilityPsuDescriptor -Name CapabilityPsuDescriptorName
$CapabilityPsuDescriptor | Set-IntersightCapabilityPsuDescriptor -Description 'Updated description'

