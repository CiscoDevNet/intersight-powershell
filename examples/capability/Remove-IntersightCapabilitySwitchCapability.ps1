
#Get the CapabilitySwitchCapability to delete
$CapabilitySwitchCapability = Remove-IntersightCapabilitySwitchCapability -Name CapabilitySwitchCapabilityName
$CapabilitySwitchCapability | Remove-IntersightCapabilitySwitchCapability

#Remove the server profile by Moid.
Remove-IntersightCapabilitySwitchCapability -Moid 123bc2222287wee
