
#Get the KubernetesContainerRuntimePolicy to delete
$KubernetesContainerRuntimePolicy = Get-IntersightKubernetesContainerRuntimePolicy -Name KubernetesContainerRuntimePolicyName
$KubernetesContainerRuntimePolicy | Remove-IntersightKubernetesContainerRuntimePolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesContainerRuntimePolicy -Moid '<Replace with Moid>'
