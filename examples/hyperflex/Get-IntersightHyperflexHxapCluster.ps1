#Get the HyperflexHxapCluster by Name
$HyperflexHxapClusterByName = Get-IntersightHyperflexHxapCluster -Name HyperflexHxapClusterName

#Get the List of ServerProfiles
$HyperflexHxapClusterList = Get-IntersightHyperflexHxapCluster

#Get the list of HyperflexHxapCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexHxapClusterByOrg = Get-IntersightHyperflexHxapCluster -Organization $org

#Get the HyperflexHxapCluster based on query Parameter
$HyperflexHxapClusterByQueryParam = Get-IntersightHyperflexHxapCluster -Filter Name eq HyperflexHxapClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .