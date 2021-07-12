
#Get the KubernetesService to delete
$KubernetesService = Remove-IntersightKubernetesService -Name KubernetesServiceName
$KubernetesService | Remove-IntersightKubernetesService

#Remove the server profile by Moid.
Remove-IntersightKubernetesService -Moid 123bc2222287wee
