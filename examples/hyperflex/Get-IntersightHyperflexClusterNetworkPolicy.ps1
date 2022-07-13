#Get the HyperflexClusterNetworkPolicy by Name
$HyperflexClusterNetworkPolicyByName = Get-IntersightHyperflexClusterNetworkPolicy -Name HyperflexClusterNetworkPolicyName

#Get the List of ServerProfiles
$HyperflexClusterNetworkPolicyList = Get-IntersightHyperflexClusterNetworkPolicy

#Get the list of HyperflexClusterNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$HyperflexClusterNetworkPolicyByOrg = Get-IntersightHyperflexClusterNetworkPolicy -Organization $org

#Get the HyperflexClusterNetworkPolicy based on query Parameter
$HyperflexClusterNetworkPolicyByQueryParam = Get-IntersightHyperflexClusterNetworkPolicy -Filter Name eq HyperflexClusterNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .