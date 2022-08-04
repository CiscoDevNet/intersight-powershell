
#Get the KubernetesVirtualMachineNodeProfile to delete
$KubernetesVirtualMachineNodeProfile = Get-IntersightKubernetesVirtualMachineNodeProfile -Name KubernetesVirtualMachineNodeProfileName
$KubernetesVirtualMachineNodeProfile | Remove-IntersightKubernetesVirtualMachineNodeProfile

#Remove the server profile by Moid.
Remove-IntersightKubernetesVirtualMachineNodeProfile -Moid '<Replace with Moid>'
