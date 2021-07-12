
#Get the FabricUplinkRole to delete
$FabricUplinkRole = Remove-IntersightFabricUplinkRole -Name FabricUplinkRoleName
$FabricUplinkRole | Remove-IntersightFabricUplinkRole

#Remove the server profile by Moid.
Remove-IntersightFabricUplinkRole -Moid 123bc2222287wee
