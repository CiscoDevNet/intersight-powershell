
#Get the KubernetesIngress to delete
$KubernetesIngress = Get-IntersightKubernetesIngress -Name KubernetesIngressName
$KubernetesIngress | Remove-IntersightKubernetesIngress

#Remove the server profile by Moid.
Remove-IntersightKubernetesIngress -Moid '<Replace with Moid>'
