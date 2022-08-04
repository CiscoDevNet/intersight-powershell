$capabilities1 = Get-IntersightCapabilityFanmoduledescriptor -Moid '<Replace with Moid>'

$capability_fan_module_descriptor1 = New-IntersightCapabilityFanModuleDescriptor -Capabilities $capabilities1 -Description 'capability of fan module descriptor' -Model 'UCSC-C3X60-FANM' -Revision '0' -Vendor 'Cisco Systems Inc'