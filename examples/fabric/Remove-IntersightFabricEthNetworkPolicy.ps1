
#Get the FabricEthNetworkPolicy to delete
$FabricEthNetworkPolicy = Get-IntersightFabricEthNetworkPolicy -Name FabricEthNetworkPolicyName
$FabricEthNetworkPolicy | Remove-IntersightFabricEthNetworkPolicy

#Remove the FabricEthNetworkPolicy by Moid.
Remove-IntersightFabricEthNetworkPolicy -Moid '<Replace with Moid>'
