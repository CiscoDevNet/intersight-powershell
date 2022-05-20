
#Get the KubernetesSysConfigPolicy to delete
$KubernetesSysConfigPolicy = Get-IntersightKubernetesSysConfigPolicy -Name KubernetesSysConfigPolicyName
$KubernetesSysConfigPolicy | Remove-IntersightKubernetesSysConfigPolicy

#Remove the server profile by Moid.
Remove-IntersightKubernetesSysConfigPolicy -Moid '<Replace with Moid>'
