
#Get the HyperflexHxapCluster to Update
$HyperflexHxapCluster = Get-IntersightHyperflexHxapCluster -Name HyperflexHxapClusterName
$HyperflexHxapCluster | Set-IntersightHyperflexHxapCluster -Description 'Updated description'
