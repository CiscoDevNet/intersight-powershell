
#Get the HyperflexHxapCluster to delete
$HyperflexHxapCluster = Get-IntersightHyperflexHxapCluster -Name HyperflexHxapClusterName
$HyperflexHxapCluster | Remove-IntersightHyperflexHxapCluster

#Remove the HyperflexHxapCluster by Moid.
Remove-IntersightHyperflexHxapCluster -Moid '<Replace with Moid>'
