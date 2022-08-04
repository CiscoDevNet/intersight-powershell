
#Get the FabricSwitchControlPolicy to delete
$FabricSwitchControlPolicy = Get-IntersightFabricSwitchControlPolicy -Name FabricSwitchControlPolicyName
$FabricSwitchControlPolicy | Remove-IntersightFabricSwitchControlPolicy

#Remove the FabricSwitchControlPolicy by Moid.
Remove-IntersightFabricSwitchControlPolicy -Moid '<Replace with Moid>'
