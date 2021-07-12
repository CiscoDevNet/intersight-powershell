
#Get the KubernetesDaemonSet to delete
$KubernetesDaemonSet = Remove-IntersightKubernetesDaemonSet -Name KubernetesDaemonSetName
$KubernetesDaemonSet | Remove-IntersightKubernetesDaemonSet

#Remove the server profile by Moid.
Remove-IntersightKubernetesDaemonSet -Moid 123bc2222287wee
