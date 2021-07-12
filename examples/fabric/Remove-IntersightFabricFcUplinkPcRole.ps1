
#Get the FabricFcUplinkPcRole to delete
$FabricFcUplinkPcRole = Remove-IntersightFabricFcUplinkPcRole -Name FabricFcUplinkPcRoleName
$FabricFcUplinkPcRole | Remove-IntersightFabricFcUplinkPcRole

#Remove the server profile by Moid.
Remove-IntersightFabricFcUplinkPcRole -Moid 123bc2222287wee
