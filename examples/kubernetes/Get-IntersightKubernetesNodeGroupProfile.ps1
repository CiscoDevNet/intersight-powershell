#Get the KubernetesNodeGroupProfile by Name
$KubernetesNodeGroupProfileByName = Get-IntersightKubernetesNodeGroupProfile -Name KubernetesNodeGroupProfileName

#Get the List of ServerProfiles
$KubernetesNodeGroupProfileList = Get-IntersightKubernetesNodeGroupProfile

#Get the list of KubernetesNodeGroupProfile under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$KubernetesNodeGroupProfileByOrg = Get-IntersightKubernetesNodeGroupProfile -Organization $org

#Get the KubernetesNodeGroupProfile based on query Parameter
$KubernetesNodeGroupProfileByQueryParam = Get-IntersightKubernetesNodeGroupProfile -Filter Name eq KubernetesNodeGroupProfileName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .