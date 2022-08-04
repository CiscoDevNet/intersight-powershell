
#Get the KubernetesClusterAddonProfile to delete
$KubernetesClusterAddonProfile = Get-IntersightKubernetesClusterAddonProfile -Name KubernetesClusterAddonProfileName
$KubernetesClusterAddonProfile | Remove-IntersightKubernetesClusterAddonProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesClusterAddonProfile -Moid '<Replace with Moid>'
