$port_policy1 = Get-IntersightFabricPortpolicy -Moid '<Replace with Moid>'

$fabric_server_role1 = New-IntersightFabricServerRole -PortPolicy $port_policy1 -AggregatePortId 0 -PortId 16 -SlotId 1