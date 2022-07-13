#Get the KubernetesAddonRepository by Name
$KubernetesAddonRepositoryByName = Get-IntersightKubernetesAddonRepository -Name KubernetesAddonRepositoryName

#Get the List of ServerProfiles
$KubernetesAddonRepositoryList = Get-IntersightKubernetesAddonRepository

#Get the list of KubernetesAddonRepository under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesAddonRepositoryByOrg = Get-IntersightKubernetesAddonRepository -Organization $org

#Get the KubernetesAddonRepository based on query Parameter
$KubernetesAddonRepositoryByQueryParam = Get-IntersightKubernetesAddonRepository -Filter Name eq KubernetesAddonRepositoryName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .