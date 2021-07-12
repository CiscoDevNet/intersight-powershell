#Get the KubernetesConfigResultEntry by Name
$KubernetesConfigResultEntryByName = Get-IntersightKubernetesConfigResultEntry -Name KubernetesConfigResultEntryName

#Get the List of ServerProfiles
$KubernetesConfigResultEntryList = Get-IntersightKubernetesConfigResultEntry

#Get the list of KubernetesConfigResultEntry under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesConfigResultEntryByOrg = Get-IntersightKubernetesConfigResultEntry -Organization $org

#Get the KubernetesConfigResultEntry based on query Parameter
$KubernetesConfigResultEntryByQueryParam = Get-IntersightKubernetesConfigResultEntry -Filter Name eq KubernetesConfigResultEntryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .