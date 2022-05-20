
#Get the CapabilitySwitchCapability to Update
$CapabilitySwitchCapability = Get-IntersightCapabilitySwitchCapability -Name CapabilitySwitchCapabilityName
$CapabilitySwitchCapability | Set-IntersightCapabilitySwitchCapability -Description 'Updated description'