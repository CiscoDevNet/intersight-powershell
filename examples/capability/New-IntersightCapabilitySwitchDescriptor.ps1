$capabilities1 = Get-IntersightCapabilitySwitchdescriptor -Moid '<Replace with Moid>'

$capability_switch_descriptor1 = New-IntersightCapabilitySwitchDescriptor -Capabilities $capabilities1 -Description 'capability switch descriptor' -Model 'UCS-FI-6454' -Vendor 'Cisco Systems Inc'