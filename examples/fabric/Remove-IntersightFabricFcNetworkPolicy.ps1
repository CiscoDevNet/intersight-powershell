
#Get the FabricFcNetworkPolicy to delete
$FabricFcNetworkPolicy = Remove-IntersightFabricFcNetworkPolicy -Name FabricFcNetworkPolicyName
$FabricFcNetworkPolicy | Remove-IntersightFabricFcNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricFcNetworkPolicy -Moid 123bc2222287wee
