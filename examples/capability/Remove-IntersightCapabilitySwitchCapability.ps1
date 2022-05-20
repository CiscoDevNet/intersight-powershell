
#Get the CapabilitySwitchCapability to delete
$CapabilitySwitchCapability = Get-IntersightCapabilitySwitchCapability -Name CapabilitySwitchCapabilityName
$CapabilitySwitchCapability | Remove-IntersightCapabilitySwitchCapability

#Remove the CapabilitySwitchCapability by Moid.
Remove-IntersightCapabilitySwitchCapability -Moid '<Replace with Moid>'
