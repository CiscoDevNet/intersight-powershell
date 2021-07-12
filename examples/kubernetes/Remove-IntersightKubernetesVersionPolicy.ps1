
#Get the KubernetesVersionPolicy to delete
$KubernetesVersionPolicy = Remove-IntersightKubernetesVersionPolicy -Name KubernetesVersionPolicyName
$KubernetesVersionPolicy | Remove-IntersightKubernetesVersionPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesVersionPolicy -Moid 123bc2222287wee
