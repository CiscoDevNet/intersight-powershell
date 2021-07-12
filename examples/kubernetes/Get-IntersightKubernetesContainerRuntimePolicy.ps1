#Get the KubernetesContainerRuntimePolicy by Name
$KubernetesContainerRuntimePolicyByName = Get-IntersightKubernetesContainerRuntimePolicy -Name KubernetesContainerRuntimePolicyName

#Get the List of ServerProfiles
$KubernetesContainerRuntimePolicyList = Get-IntersightKubernetesContainerRuntimePolicy

#Get the list of KubernetesContainerRuntimePolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesContainerRuntimePolicyByOrg = Get-IntersightKubernetesContainerRuntimePolicy -Organization $org

#Get the KubernetesContainerRuntimePolicy based on query Parameter
$KubernetesContainerRuntimePolicyByQueryParam = Get-IntersightKubernetesContainerRuntimePolicy -Filter Name eq KubernetesContainerRuntimePolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .