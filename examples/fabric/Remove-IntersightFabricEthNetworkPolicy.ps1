
#Get the FabricEthNetworkPolicy to delete
$FabricEthNetworkPolicy = Remove-IntersightFabricEthNetworkPolicy -Name FabricEthNetworkPolicyName
$FabricEthNetworkPolicy | Remove-IntersightFabricEthNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricEthNetworkPolicy -Moid 123bc2222287wee
