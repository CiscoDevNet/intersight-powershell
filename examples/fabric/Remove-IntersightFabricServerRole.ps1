
#Get the FabricServerRole to delete
$FabricServerRole = Remove-IntersightFabricServerRole -Name FabricServerRoleName
$FabricServerRole | Remove-IntersightFabricServerRole

#Remove the server profile by Moid.
Remove-IntersightFabricServerRole -Moid 123bc2222287wee
