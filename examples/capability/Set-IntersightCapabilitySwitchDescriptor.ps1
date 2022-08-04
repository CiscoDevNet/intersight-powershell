
#Get the CapabilitySwitchDescriptor to Update
$CapabilitySwitchDescriptor = Get-IntersightCapabilitySwitchDescriptor -Name CapabilitySwitchDescriptorName
$CapabilitySwitchDescriptor | Set-IntersightCapabilitySwitchDescriptor -Description 'Updated description'
