#Get the HyperflexCluster by Name
$HyperflexClusterByName = Get-IntersightHyperflexCluster -Name HyperflexClusterName

#Get the List of ServerProfiles
$HyperflexClusterList = Get-IntersightHyperflexCluster

#Get the list of HyperflexCluster under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterByOrg = Get-IntersightHyperflexCluster -Organization $org

#Get the HyperflexCluster based on query Parameter
$HyperflexClusterByQueryParam = Get-IntersightHyperflexCluster -Filter Name eq HyperflexClusterName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .