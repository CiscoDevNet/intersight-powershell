
#Get the FabricUplinkPcRole to delete
$FabricUplinkPcRole = Remove-IntersightFabricUplinkPcRole -Name FabricUplinkPcRoleName
$FabricUplinkPcRole | Remove-IntersightFabricUplinkPcRole

#Remove the server profile by Moid.
Remove-IntersightFabricUplinkPcRole -Moid 123bc2222287wee
