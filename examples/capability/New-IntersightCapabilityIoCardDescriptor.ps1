$capabilities1 = Get-IntersightCapabilityIocarddescriptor -Moid '<Replace with Moid>'

$capability_io_card_descriptor1 = New-IntersightCapabilityIoCardDescriptor -Capabilities $capabilities1 -Description 'capability io card descriptor' -Model 'UCSC-PCIE-C25Q-04' -Vendor 'Cisco Systems Inc' -UifConnectivity 'inline'