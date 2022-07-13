#Get the KubernetesClusterAddonProfile by Name
$KubernetesClusterAddonProfileByName = Get-IntersightKubernetesClusterAddonProfile -Name KubernetesClusterAddonProfileName

#Get the List of ServerProfiles
$KubernetesClusterAddonProfileList = Get-IntersightKubernetesClusterAddonProfile

#Get the list of KubernetesClusterAddonProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesClusterAddonProfileByOrg = Get-IntersightKubernetesClusterAddonProfile -Organization $org

#Get the KubernetesClusterAddonProfile based on query Parameter
$KubernetesClusterAddonProfileByQueryParam = Get-IntersightKubernetesClusterAddonProfile -Filter Name eq KubernetesClusterAddonProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .