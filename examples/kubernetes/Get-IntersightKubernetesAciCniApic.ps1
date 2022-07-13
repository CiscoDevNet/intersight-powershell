#Get the KubernetesAciCniApic by Name
$KubernetesAciCniApicByName = Get-IntersightKubernetesAciCniApic -Name KubernetesAciCniApicName

#Get the List of ServerProfiles
$KubernetesAciCniApicList = Get-IntersightKubernetesAciCniApic

#Get the list of KubernetesAciCniApic under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesAciCniApicByOrg = Get-IntersightKubernetesAciCniApic -Organization $org

#Get the KubernetesAciCniApic based on query Parameter
$KubernetesAciCniApicByQueryParam = Get-IntersightKubernetesAciCniApic -Filter Name eq KubernetesAciCniApicName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .