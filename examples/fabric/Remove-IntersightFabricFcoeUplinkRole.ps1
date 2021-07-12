
#Get the FabricFcoeUplinkRole to delete
$FabricFcoeUplinkRole = Remove-IntersightFabricFcoeUplinkRole -Name FabricFcoeUplinkRoleName
$FabricFcoeUplinkRole | Remove-IntersightFabricFcoeUplinkRole

#Remove the server profile by Moid.
Remove-IntersightFabricFcoeUplinkRole -Moid 123bc2222287wee
