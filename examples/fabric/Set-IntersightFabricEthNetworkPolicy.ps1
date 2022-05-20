
#Get the FabricEthNetworkPolicy to Update
$FabricEthNetworkPolicy = Get-IntersightFabricEthNetworkPolicy -Name FabricEthNetworkPolicyName
$FabricEthNetworkPolicy | Set-IntersightFabricEthNetworkPolicy -Description 'Updated description'
