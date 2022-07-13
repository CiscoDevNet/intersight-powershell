#Get the KubernetesVirtualMachineInfrastructureProvider by Name
$KubernetesVirtualMachineInfrastructureProviderByName = Get-IntersightKubernetesVirtualMachineInfrastructureProvider -Name KubernetesVirtualMachineInfrastructureProviderName

#Get the List of ServerProfiles
$KubernetesVirtualMachineInfrastructureProviderList = Get-IntersightKubernetesVirtualMachineInfrastructureProvider

#Get the list of KubernetesVirtualMachineInfrastructureProvider under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesVirtualMachineInfrastructureProviderByOrg = Get-IntersightKubernetesVirtualMachineInfrastructureProvider -Organization $org

#Get the KubernetesVirtualMachineInfrastructureProvider based on query Parameter
$KubernetesVirtualMachineInfrastructureProviderByQueryParam = Get-IntersightKubernetesVirtualMachineInfrastructureProvider -Filter Name eq KubernetesVirtualMachineInfrastructureProviderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .