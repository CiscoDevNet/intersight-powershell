#Get the KubernetesClusterProfile by Name
$KubernetesClusterProfileByName = Get-IntersightKubernetesClusterProfile -Name KubernetesClusterProfileName

#Get the List of ServerProfiles
$KubernetesClusterProfileList = Get-IntersightKubernetesClusterProfile

#Get the list of KubernetesClusterProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesClusterProfileByOrg = Get-IntersightKubernetesClusterProfile -Organization $org

#Get the KubernetesClusterProfile based on query Parameter
$KubernetesClusterProfileByQueryParam = Get-IntersightKubernetesClusterProfile -Filter Name eq KubernetesClusterProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .