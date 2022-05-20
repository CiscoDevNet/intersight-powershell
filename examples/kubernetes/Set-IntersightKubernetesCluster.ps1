
#Get the KubernetesCluster to Update
$KubernetesCluster = Get-IntersightKubernetesCluster -Name KubernetesClusterName
$KubernetesCluster | Set-IntersightKubernetesCluster -Description 'Updated description'