
#Get the KubernetesDeployment to delete
$KubernetesDeployment = Remove-IntersightKubernetesDeployment -Name KubernetesDeploymentName
$KubernetesDeployment | Remove-IntersightKubernetesDeployment

#Remove the server profile by Moid.
Remove-IntersightKubernetesDeployment -Moid 123bc2222287wee
