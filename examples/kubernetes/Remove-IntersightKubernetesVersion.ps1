
#Get the KubernetesVersion to delete
$KubernetesVersion = Get-IntersightKubernetesVersion -Name KubernetesVersionName
$KubernetesVersion | Remove-IntersightKubernetesVersion

#Remove the server profile by Moid.
Remove-IntersightKubernetesVersion -Moid '<Replace with Moid>'
