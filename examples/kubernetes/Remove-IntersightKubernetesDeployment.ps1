
#Get the KubernetesDeployment to delete
$KubernetesDeployment = Get-IntersightKubernetesDeployment -Name KubernetesDeploymentName
$KubernetesDeployment | Remove-IntersightKubernetesDeployment

#Remove the server profile by Moid.
Remove-IntersightKubernetesDeployment -Moid '<Replace with Moid>'
