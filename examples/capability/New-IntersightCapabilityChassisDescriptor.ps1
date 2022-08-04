$capabilities1 = Get-IntersightCapabilityChassismanufacturingdef -Moid '<Replace with Moid>'

$capability_chassis_descriptor1 = New-IntersightCapabilityChassisDescriptor -Capabilities $capabilities1 -Description 'capability chassis descriptor' -Model 'N20-C6508' -Revision '0' -Vendor 'Cisco Systems Inc'