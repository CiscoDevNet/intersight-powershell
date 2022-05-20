
#Get the KubernetesAciCniProfile to Update
$KubernetesAciCniProfile = Get-IntersightKubernetesAciCniProfile -Name KubernetesAciCniProfileName
$KubernetesAciCniProfile | Set-IntersightKubernetesAciCniProfile -Description 'Updated description'