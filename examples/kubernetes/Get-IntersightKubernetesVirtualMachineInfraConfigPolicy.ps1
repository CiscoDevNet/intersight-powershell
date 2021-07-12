#Get the KubernetesVirtualMachineInfraConfigPolicy by Name
$KubernetesVirtualMachineInfraConfigPolicyByName = Get-IntersightKubernetesVirtualMachineInfraConfigPolicy -Name KubernetesVirtualMachineInfraConfigPolicyName

#Get the List of ServerProfiles
$KubernetesVirtualMachineInfraConfigPolicyList = Get-IntersightKubernetesVirtualMachineInfraConfigPolicy

#Get the list of KubernetesVirtualMachineInfraConfigPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesVirtualMachineInfraConfigPolicyByOrg = Get-IntersightKubernetesVirtualMachineInfraConfigPolicy -Organization $org

#Get the KubernetesVirtualMachineInfraConfigPolicy based on query Parameter
$KubernetesVirtualMachineInfraConfigPolicyByQueryParam = Get-IntersightKubernetesVirtualMachineInfraConfigPolicy -Filter Name eq KubernetesVirtualMachineInfraConfigPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .