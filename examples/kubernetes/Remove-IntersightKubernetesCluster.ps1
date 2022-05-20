
#Get the KubernetesCluster to delete
$KubernetesCluster = Get-IntersightKubernetesCluster -Name KubernetesClusterName
$KubernetesCluster | Remove-IntersightKubernetesCluster

#Remove the server profile by Moid.
Remove-IntersightKubernetesCluster -Moid '<Replace with Moid>'
