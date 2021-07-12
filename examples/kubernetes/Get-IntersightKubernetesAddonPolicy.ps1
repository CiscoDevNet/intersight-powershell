#Get the KubernetesAddonPolicy by Name
$KubernetesAddonPolicyByName = Get-IntersightKubernetesAddonPolicy -Name KubernetesAddonPolicyName

#Get the List of ServerProfiles
$KubernetesAddonPolicyList = Get-IntersightKubernetesAddonPolicy

#Get the list of KubernetesAddonPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesAddonPolicyByOrg = Get-IntersightKubernetesAddonPolicy -Organization $org

#Get the KubernetesAddonPolicy based on query Parameter
$KubernetesAddonPolicyByQueryParam = Get-IntersightKubernetesAddonPolicy -Filter Name eq KubernetesAddonPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .