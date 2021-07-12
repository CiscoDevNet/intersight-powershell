
#Get the FabricPortMode to delete
$FabricPortMode = Remove-IntersightFabricPortMode -Name FabricPortModeName
$FabricPortMode | Remove-IntersightFabricPortMode

#Remove the server profile by Moid.
Remove-IntersightFabricPortMode -Moid 123bc2222287wee
