#Get the KubernetesVersionPolicy by Name
$KubernetesVersionPolicyByName = Get-IntersightKubernetesVersionPolicy -Name KubernetesVersionPolicyName

#Get the List of ServerProfiles
$KubernetesVersionPolicyList = Get-IntersightKubernetesVersionPolicy

#Get the list of KubernetesVersionPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesVersionPolicyByOrg = Get-IntersightKubernetesVersionPolicy -Organization $org

#Get the KubernetesVersionPolicy based on query Parameter
$KubernetesVersionPolicyByQueryParam = Get-IntersightKubernetesVersionPolicy -Filter Name eq KubernetesVersionPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .