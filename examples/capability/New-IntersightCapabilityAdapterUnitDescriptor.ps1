$capabilities1 = Get-IntersightCapabilityAdapterunitdescriptor -Moid '<Replace with Moid>'

$capability_adapter_unit_descriptor1 = New-IntersightCapabilityAdapterUnitDescriptor -Capabilities $capabilities1 -Description 'capability adapter unit descriptor' -Model 'Cisco Systems Inc' -ConnectivityOrder 'sequential' -EthernetPortSpeed 40