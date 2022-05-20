
#Get the KubernetesSysConfigPolicy to Update
$KubernetesSysConfigPolicy = Get-IntersightKubernetesSysConfigPolicy -Name KubernetesSysConfigPolicyName
$KubernetesSysConfigPolicy | Set-IntersightKubernetesSysConfigPolicy -Description 'Updated description'