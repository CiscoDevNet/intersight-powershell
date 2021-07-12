
#Get the FabricFcUplinkRole to delete
$FabricFcUplinkRole = Remove-IntersightFabricFcUplinkRole -Name FabricFcUplinkRoleName
$FabricFcUplinkRole | Remove-IntersightFabricFcUplinkRole

#Remove the server profile by Moid.
Remove-IntersightFabricFcUplinkRole -Moid 123bc2222287wee
