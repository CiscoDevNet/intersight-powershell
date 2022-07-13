#Get the KubernetesCluster by Name
$KubernetesClusterByName = Get-IntersightKubernetesCluster -Name KubernetesClusterName

#Get the List of ServerProfiles
$KubernetesClusterList = Get-IntersightKubernetesCluster

#Get the list of KubernetesCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$KubernetesClusterByOrg = Get-IntersightKubernetesCluster -Organization $org

#Get the KubernetesCluster based on query Parameter
$KubernetesClusterByQueryParam = Get-IntersightKubernetesCluster -Filter Name eq KubernetesClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .