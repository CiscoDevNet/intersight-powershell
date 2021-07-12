
#Get the KubernetesPod to delete
$KubernetesPod = Remove-IntersightKubernetesPod -Name KubernetesPodName
$KubernetesPod | Remove-IntersightKubernetesPod

#Remove the server profile by Moid.
Remove-IntersightKubernetesPod -Moid 123bc2222287wee
