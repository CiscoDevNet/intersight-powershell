#Get the KubernetesStatefulSet by Name
$KubernetesStatefulSetByName = Get-IntersightKubernetesStatefulSet -Name KubernetesStatefulSetName

#Get the List of ServerProfiles
$KubernetesStatefulSetList = Get-IntersightKubernetesStatefulSet

#Get the list of KubernetesStatefulSet under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesStatefulSetByOrg = Get-IntersightKubernetesStatefulSet -Organization $org

#Get the KubernetesStatefulSet based on query Parameter
$KubernetesStatefulSetByQueryParam = Get-IntersightKubernetesStatefulSet -Filter Name eq KubernetesStatefulSetName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .