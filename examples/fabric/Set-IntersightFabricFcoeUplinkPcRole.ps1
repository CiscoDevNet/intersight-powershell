
#Get the FabricFcoeUplinkPcRole to Update
$FabricFcoeUplinkPcRole = Get-IntersightFabricFcoeUplinkPcRole -Name FabricFcoeUplinkPcRoleName
$FabricFcoeUplinkPcRole | Set-IntersightFabricFcoeUplinkPcRole -Description 'Updated description'
