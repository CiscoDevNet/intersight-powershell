
#Get the KubernetesService to delete
$KubernetesService = Get-IntersightKubernetesService -Name KubernetesServiceName
$KubernetesService | Remove-IntersightKubernetesService

#Remove the server profile by Moid.
Remove-IntersightKubernetesService -Moid '<Replace with Moid>'
