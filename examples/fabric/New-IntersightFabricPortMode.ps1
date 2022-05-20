$port_policy1 = Get-IntersightFabricPortpolicy -Moid '<Replace with Moid>'

$fabric_port_mode1 = New-IntersightFabricPortMode -PortPolicy $port_policy1 -CustomMode 'FibreChannel' -PortIdEnd 8 -PortIdStart 1 -SlotId 1