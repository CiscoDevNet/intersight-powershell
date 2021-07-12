#Get the KubernetesConfigResult by Name
$KubernetesConfigResultByName = Get-IntersightKubernetesConfigResult -Name KubernetesConfigResultName

#Get the List of ServerProfiles
$KubernetesConfigResultList = Get-IntersightKubernetesConfigResult

#Get the list of KubernetesConfigResult under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesConfigResultByOrg = Get-IntersightKubernetesConfigResult -Organization $org

#Get the KubernetesConfigResult based on query Parameter
$KubernetesConfigResultByQueryParam = Get-IntersightKubernetesConfigResult -Filter Name eq KubernetesConfigResultName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .