#Get the HyperflexClusterReplicationNetworkPolicy by Name
$HyperflexClusterReplicationNetworkPolicyByName = Get-IntersightHyperflexClusterReplicationNetworkPolicy -Name HyperflexClusterReplicationNetworkPolicyName

#Get the List of ServerProfiles
$HyperflexClusterReplicationNetworkPolicyList = Get-IntersightHyperflexClusterReplicationNetworkPolicy

#Get the list of HyperflexClusterReplicationNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$HyperflexClusterReplicationNetworkPolicyByOrg = Get-IntersightHyperflexClusterReplicationNetworkPolicy -Organization $org

#Get the HyperflexClusterReplicationNetworkPolicy based on query Parameter
$HyperflexClusterReplicationNetworkPolicyByQueryParam = Get-IntersightHyperflexClusterReplicationNetworkPolicy -Filter Name eq HyperflexClusterReplicationNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .