
#Get the KubernetesNodeGroupProfile to delete
$KubernetesNodeGroupProfile = Get-IntersightKubernetesNodeGroupProfile -Name KubernetesNodeGroupProfileName
$KubernetesNodeGroupProfile | Remove-IntersightKubernetesNodeGroupProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesNodeGroupProfile -Moid '<Replace with Moid>'
