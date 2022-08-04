
#Get the KubernetesPod to delete
$KubernetesPod = Get-IntersightKubernetesPod -Name KubernetesPodName
$KubernetesPod | Remove-IntersightKubernetesPod

#Remove the server profile by Moid.
Remove-IntersightKubernetesPod -Moid '<Replace with Moid>'
