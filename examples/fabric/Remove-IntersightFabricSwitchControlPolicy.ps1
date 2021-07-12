
#Get the FabricSwitchControlPolicy to delete
$FabricSwitchControlPolicy = Remove-IntersightFabricSwitchControlPolicy -Name FabricSwitchControlPolicyName
$FabricSwitchControlPolicy | Remove-IntersightFabricSwitchControlPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricSwitchControlPolicy -Moid 123bc2222287wee
