
#Get the KubernetesSysConfigPolicy to delete
$KubernetesSysConfigPolicy = Remove-IntersightKubernetesSysConfigPolicy -Name KubernetesSysConfigPolicyName
$KubernetesSysConfigPolicy | Remove-IntersightKubernetesSysConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesSysConfigPolicy -Moid 123bc2222287wee
