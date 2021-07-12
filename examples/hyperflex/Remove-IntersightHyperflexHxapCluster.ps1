
#Get the HyperflexHxapCluster to delete
$HyperflexHxapCluster = Remove-IntersightHyperflexHxapCluster -Name HyperflexHxapClusterName
$HyperflexHxapCluster | Remove-IntersightHyperflexHxapCluster

#Remove the server profile by Moid.
Remove-IntersightHyperflexHxapCluster -Moid 123bc2222287wee
