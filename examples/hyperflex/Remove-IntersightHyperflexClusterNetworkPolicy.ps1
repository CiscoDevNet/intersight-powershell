
#Get the HyperflexClusterNetworkPolicy to delete
$HyperflexClusterNetworkPolicy = Get-IntersightHyperflexClusterNetworkPolicy -Name HyperflexClusterNetworkPolicyName
$HyperflexClusterNetworkPolicy | Remove-IntersightHyperflexClusterNetworkPolicy

#Remove the HyperflexClusterNetworkPolicy by Moid.
Remove-IntersightHyperflexClusterNetworkPolicy -Moid '<Replace with Moid>'
