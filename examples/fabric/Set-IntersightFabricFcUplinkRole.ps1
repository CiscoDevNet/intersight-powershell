
#Get the FabricFcUplinkRole to Update
$FabricFcUplinkRole = Get-IntersightFabricFcUplinkRole -Name FabricFcUplinkRoleName
$FabricFcUplinkRole | Set-IntersightFabricFcUplinkRole -Description 'Updated description'
