
#Get the HyperflexClusterReplicationNetworkPolicy to delete
$HyperflexClusterReplicationNetworkPolicy = Remove-IntersightHyperflexClusterReplicationNetworkPolicy -Name HyperflexClusterReplicationNetworkPolicyName
$HyperflexClusterReplicationNetworkPolicy | Remove-IntersightHyperflexClusterReplicationNetworkPolicy

#Remove the server profile by Moid.
Remove-IntersightHyperflexClusterReplicationNetworkPolicy -Moid 123bc2222287wee
