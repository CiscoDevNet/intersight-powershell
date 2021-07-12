
#Get the KubernetesIngress to delete
$KubernetesIngress = Remove-IntersightKubernetesIngress -Name KubernetesIngressName
$KubernetesIngress | Remove-IntersightKubernetesIngress

#Remove the server profile by Moid.
Remove-IntersightKubernetesIngress -Moid 123bc2222287wee
