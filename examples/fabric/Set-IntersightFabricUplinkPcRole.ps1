
#Get the FabricUplinkPcRole to Update
$FabricUplinkPcRole = Get-IntersightFabricUplinkPcRole -Name FabricUplinkPcRoleName
$FabricUplinkPcRole | Set-IntersightFabricUplinkPcRole -Description 'Updated description'
