
#Get the FabricEthNetworkControlPolicy to delete
$FabricEthNetworkControlPolicy = Get-IntersightFabricEthNetworkControlPolicy -Name FabricEthNetworkControlPolicyName
$FabricEthNetworkControlPolicy | Remove-IntersightFabricEthNetworkControlPolicy

#Remove the FabricEthNetworkControlPolicy by Moid.
Remove-IntersightFabricEthNetworkControlPolicy -Moid '<Replace with Moid>'
