#Get the KubernetesService by Name
$KubernetesServiceByName = Get-IntersightKubernetesService -Name KubernetesServiceName

#Get the List of ServerProfiles
$KubernetesServiceList = Get-IntersightKubernetesService

#Get the list of KubernetesService under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesServiceByOrg = Get-IntersightKubernetesService -Organization $org

#Get the KubernetesService based on query Parameter
$KubernetesServiceByQueryParam = Get-IntersightKubernetesService -Filter Name eq KubernetesServiceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .