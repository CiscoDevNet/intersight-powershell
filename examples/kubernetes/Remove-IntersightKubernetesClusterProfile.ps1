
#Get the KubernetesClusterProfile to delete
$KubernetesClusterProfile = Get-IntersightKubernetesClusterProfile -Name KubernetesClusterProfileName
$KubernetesClusterProfile | Remove-IntersightKubernetesClusterProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesClusterProfile -Moid '<Replace with Moid>'
