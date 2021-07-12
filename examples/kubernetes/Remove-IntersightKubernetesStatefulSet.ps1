
#Get the KubernetesStatefulSet to delete
$KubernetesStatefulSet = Remove-IntersightKubernetesStatefulSet -Name KubernetesStatefulSetName
$KubernetesStatefulSet | Remove-IntersightKubernetesStatefulSet

#Remove the server profile by Moid.
Remove-IntersightKubernetesStatefulSet -Moid 123bc2222287wee
