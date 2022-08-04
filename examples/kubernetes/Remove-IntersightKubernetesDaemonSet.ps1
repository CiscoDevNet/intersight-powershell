
#Get the KubernetesDaemonSet to delete
$KubernetesDaemonSet = Get-IntersightKubernetesDaemonSet -Name KubernetesDaemonSetName
$KubernetesDaemonSet | Remove-IntersightKubernetesDaemonSet

#Remove the server profile by Moid.
Remove-IntersightKubernetesDaemonSet -Moid '<Replace with Moid>'
