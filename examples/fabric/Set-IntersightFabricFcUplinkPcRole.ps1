
#Get the FabricFcUplinkPcRole to Update
$FabricFcUplinkPcRole = Get-IntersightFabricFcUplinkPcRole -Name FabricFcUplinkPcRoleName
$FabricFcUplinkPcRole | Set-IntersightFabricFcUplinkPcRole -Description 'Updated description'
