
#Get the FabricFcNetworkPolicy to Update
$FabricFcNetworkPolicy = Get-IntersightFabricFcNetworkPolicy -Name FabricFcNetworkPolicyName
$FabricFcNetworkPolicy | Set-IntersightFabricFcNetworkPolicy -Description 'Updated description'
