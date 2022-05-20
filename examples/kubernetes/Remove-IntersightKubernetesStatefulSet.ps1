
#Get the KubernetesStatefulSet to delete
$KubernetesStatefulSet = Get-IntersightKubernetesStatefulSet -Name KubernetesStatefulSetName
$KubernetesStatefulSet | Remove-IntersightKubernetesStatefulSet

#Remove the server profile by Moid.
Remove-IntersightKubernetesStatefulSet -Moid '<Replace with Moid>'
