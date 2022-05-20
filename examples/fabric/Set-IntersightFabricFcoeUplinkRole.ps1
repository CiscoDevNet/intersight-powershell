
#Get the FabricFcoeUplinkRole to Update
$FabricFcoeUplinkRole = Get-IntersightFabricFcoeUplinkRole -Name FabricFcoeUplinkRoleName
$FabricFcoeUplinkRole | Set-IntersightFabricFcoeUplinkRole -Description 'Updated description'
