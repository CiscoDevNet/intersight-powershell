
#Get the FabricFcNetworkPolicy to delete
$FabricFcNetworkPolicy = Get-IntersightFabricFcNetworkPolicy -Name FabricFcNetworkPolicyName
$FabricFcNetworkPolicy | Remove-IntersightFabricFcNetworkPolicy

#Remove the FabricFcNetworkPolicy by Moid.
Remove-IntersightFabricFcNetworkPolicy -Moid '<Replace with Moid>'
