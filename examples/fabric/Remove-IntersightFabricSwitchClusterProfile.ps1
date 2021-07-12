
#Get the FabricSwitchClusterProfile to delete
$FabricSwitchClusterProfile = Remove-IntersightFabricSwitchClusterProfile -Name FabricSwitchClusterProfileName
$FabricSwitchClusterProfile | Remove-IntersightFabricSwitchClusterProfile

#Remove the server profile by Moid.
Remove-IntersightFabricSwitchClusterProfile -Moid 123bc2222287wee
