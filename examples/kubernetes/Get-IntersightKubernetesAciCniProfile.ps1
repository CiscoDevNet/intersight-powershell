#Get the KubernetesAciCniProfile by Name
$KubernetesAciCniProfileByName = Get-IntersightKubernetesAciCniProfile -Name KubernetesAciCniProfileName

#Get the List of ServerProfiles
$KubernetesAciCniProfileList = Get-IntersightKubernetesAciCniProfile

#Get the list of KubernetesAciCniProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesAciCniProfileByOrg = Get-IntersightKubernetesAciCniProfile -Organization $org

#Get the KubernetesAciCniProfile based on query Parameter
$KubernetesAciCniProfileByQueryParam = Get-IntersightKubernetesAciCniProfile -Filter Name eq KubernetesAciCniProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .