
#Get the FabricUplinkRole to Update
$FabricUplinkRole = Get-IntersightFabricUplinkRole -Name FabricUplinkRoleName
$FabricUplinkRole | Set-IntersightFabricUplinkRole -Description 'Updated description'
