
#Get the FabricSwitchClusterProfile to delete
$FabricSwitchClusterProfile = Get-IntersightFabricSwitchClusterProfile -Name FabricSwitchClusterProfileName
$FabricSwitchClusterProfile | Remove-IntersightFabricSwitchClusterProfile

#Remove the FabricSwitchClusterProfile by Moid.
Remove-IntersightFabricSwitchClusterProfile -Moid '<Replace with Moid>'
