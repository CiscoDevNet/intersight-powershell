#Get the KubernetesVirtualMachineInstanceType by Name
$KubernetesVirtualMachineInstanceTypeByName = Get-IntersightKubernetesVirtualMachineInstanceType -Name KubernetesVirtualMachineInstanceTypeName

#Get the List of ServerProfiles
$KubernetesVirtualMachineInstanceTypeList = Get-IntersightKubernetesVirtualMachineInstanceType

#Get the list of KubernetesVirtualMachineInstanceType under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesVirtualMachineInstanceTypeByOrg = Get-IntersightKubernetesVirtualMachineInstanceType -Organization $org

#Get the KubernetesVirtualMachineInstanceType based on query Parameter
$KubernetesVirtualMachineInstanceTypeByQueryParam = Get-IntersightKubernetesVirtualMachineInstanceType -Filter Name eq KubernetesVirtualMachineInstanceTypeName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .