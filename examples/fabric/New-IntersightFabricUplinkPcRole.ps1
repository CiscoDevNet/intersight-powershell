$port_policy1 = Get-IntersightFabricPortpolicy -Moid '<Replace with Moid>'

$ports1 = Initialize-IntersightFabricPortidentifier -PortId 1 -AggregatePortId 0 -SlotId 1 -ClassId 'fabric.PortIdentifier'

$ports2 = Initialize-IntersightFabricPortidentifier -PortId 2 -AggregatePortId 0 -SlotId 1 -ClassId 'fabric.PortIdentifier'

$fabric_uplink_pc_role1 = New-IntersightFabricUplinkPcRole -PortPolicy $port_policy1 -Ports @($ports1,$ports2,) -AdminSpeed 'Auto'