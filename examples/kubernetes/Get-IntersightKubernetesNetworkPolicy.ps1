#Get the KubernetesNetworkPolicy by Name
$KubernetesNetworkPolicyByName = Get-IntersightKubernetesNetworkPolicy -Name KubernetesNetworkPolicyName

#Get the List of ServerProfiles
$KubernetesNetworkPolicyList = Get-IntersightKubernetesNetworkPolicy

#Get the list of KubernetesNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesNetworkPolicyByOrg = Get-IntersightKubernetesNetworkPolicy -Organization $org

#Get the KubernetesNetworkPolicy based on query Parameter
$KubernetesNetworkPolicyByQueryParam = Get-IntersightKubernetesNetworkPolicy -Filter Name eq KubernetesNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .