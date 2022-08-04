
#Get the KubernetesVersionPolicy to delete
$KubernetesVersionPolicy = Get-IntersightKubernetesVersionPolicy -Name KubernetesVersionPolicyName
$KubernetesVersionPolicy | Remove-IntersightKubernetesVersionPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesVersionPolicy -Moid '<Replace with Moid>'
