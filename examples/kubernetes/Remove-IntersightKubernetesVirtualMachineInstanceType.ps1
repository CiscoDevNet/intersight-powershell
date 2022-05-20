
#Get the KubernetesVirtualMachineInstanceType to delete
$KubernetesVirtualMachineInstanceType = Get-IntersightKubernetesVirtualMachineInstanceType -Name KubernetesVirtualMachineInstanceTypeName
$KubernetesVirtualMachineInstanceType | Remove-IntersightKubernetesVirtualMachineInstanceType

#Remove the server profile by Moid.
Remove-IntersightKubernetesVirtualMachineInstanceType -Moid '<Replace with Moid>'
