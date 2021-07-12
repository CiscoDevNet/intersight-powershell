
#Get the HyperflexClusterNetworkPolicy to delete
$HyperflexClusterNetworkPolicy = Remove-IntersightHyperflexClusterNetworkPolicy -Name HyperflexClusterNetworkPolicyName
$HyperflexClusterNetworkPolicy | Remove-IntersightHyperflexClusterNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexClusterNetworkPolicy -Moid 123bc2222287wee
