
#Get the FabricSwitchProfile to delete
$FabricSwitchProfile = Remove-IntersightFabricSwitchProfile -Name FabricSwitchProfileName
$FabricSwitchProfile | Remove-IntersightFabricSwitchProfile

#Remove the server profile by Moid.
Remove-IntersightFabricSwitchProfile -Moid 123bc2222287wee
