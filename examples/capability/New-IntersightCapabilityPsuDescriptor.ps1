$capabilities1 = Get-IntersightCapabilityPsudescriptor -Moid '<Replace with Moid>'

$capability_psu_descriptor1 = New-IntersightCapabilityPsuDescriptor -Capabilities $capabilities1 -Description 'capability psu descriptor' -Model 'UCSC-PSU1-1050W' -Vendor 'Cisco Systems Inc'