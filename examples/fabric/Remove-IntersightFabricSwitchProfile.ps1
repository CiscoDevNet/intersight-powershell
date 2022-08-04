
#Get the FabricSwitchProfile to delete
$FabricSwitchProfile = Get-IntersightFabricSwitchProfile -Name FabricSwitchProfileName
$FabricSwitchProfile | Remove-IntersightFabricSwitchProfile

#Remove the FabricSwitchProfile by Moid.
Remove-IntersightFabricSwitchProfile -Moid '<Replace with Moid>'
