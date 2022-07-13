#Get the KubernetesVersion by Name
$KubernetesVersionByName = Get-IntersightKubernetesVersion -Name KubernetesVersionName

#Get the List of ServerProfiles
$KubernetesVersionList = Get-IntersightKubernetesVersion

#Get the list of KubernetesVersion under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesVersionByOrg = Get-IntersightKubernetesVersion -Organization $org

#Get the KubernetesVersion based on query Parameter
$KubernetesVersionByQueryParam = Get-IntersightKubernetesVersion -Filter Name eq KubernetesVersionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .