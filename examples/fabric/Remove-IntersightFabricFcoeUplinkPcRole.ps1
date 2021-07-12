
#Get the FabricFcoeUplinkPcRole to delete
$FabricFcoeUplinkPcRole = Remove-IntersightFabricFcoeUplinkPcRole -Name FabricFcoeUplinkPcRoleName
$FabricFcoeUplinkPcRole | Remove-IntersightFabricFcoeUplinkPcRole

#Remove the server profile by Moid.
Remove-IntersightFabricFcoeUplinkPcRole -Moid 123bc2222287wee
