#Get the KubernetesVirtualMachineNodeProfile by Name
$KubernetesVirtualMachineNodeProfileByName = Get-IntersightKubernetesVirtualMachineNodeProfile -Name KubernetesVirtualMachineNodeProfileName

#Get the List of ServerProfiles
$KubernetesVirtualMachineNodeProfileList = Get-IntersightKubernetesVirtualMachineNodeProfile

#Get the list of KubernetesVirtualMachineNodeProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesVirtualMachineNodeProfileByOrg = Get-IntersightKubernetesVirtualMachineNodeProfile -Organization $org

#Get the KubernetesVirtualMachineNodeProfile based on query Parameter
$KubernetesVirtualMachineNodeProfileByQueryParam = Get-IntersightKubernetesVirtualMachineNodeProfile -Filter Name eq KubernetesVirtualMachineNodeProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .