
#Get the KubernetesClusterAddonProfile to delete
$KubernetesClusterAddonProfile = Remove-IntersightKubernetesClusterAddonProfile -Name KubernetesClusterAddonProfileName
$KubernetesClusterAddonProfile | Remove-IntersightKubernetesClusterAddonProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesClusterAddonProfile -Moid 123bc2222287wee
