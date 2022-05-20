$capabilities1 = Get-IntersightCapabilityCimcfirmwaredescriptor -Moid '<Replace with Moid>'

$capability_cimc_firmware_descriptor1 = New-IntersightCapabilityCimcFirmwareDescriptor -Capabilities $capabilities1 -Description 'capability of cimc firmware descriptor' -Model 'UCSC-C240-M5L' -Revision '0' -Vendor 'Cisco Systems Inc'