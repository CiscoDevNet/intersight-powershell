
#Get the KubernetesCluster to delete
$KubernetesCluster = Remove-IntersightKubernetesCluster -Name KubernetesClusterName
$KubernetesCluster | Remove-IntersightKubernetesCluster

#Remove the server profile by Moid.
Remove-IntersightKubernetesCluster -Moid 123bc2222287wee
