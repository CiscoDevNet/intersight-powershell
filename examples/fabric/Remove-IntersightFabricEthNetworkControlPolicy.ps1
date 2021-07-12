
#Get the FabricEthNetworkControlPolicy to delete
$FabricEthNetworkControlPolicy = Remove-IntersightFabricEthNetworkControlPolicy -Name FabricEthNetworkControlPolicyName
$FabricEthNetworkControlPolicy | Remove-IntersightFabricEthNetworkControlPolicy

#Remove the server profile by Moid.
Remove-IntersightFabricEthNetworkControlPolicy -Moid 123bc2222287wee
