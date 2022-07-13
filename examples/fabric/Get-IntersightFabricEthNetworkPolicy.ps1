#Get the FabricEthNetworkPolicy by Name
$FabricEthNetworkPolicyByName = Get-IntersightFabricEthNetworkPolicy -Name FabricEthNetworkPolicyName

#Get the List of ServerProfiles
$FabricEthNetworkPolicyList = Get-IntersightFabricEthNetworkPolicy

#Get the list of FabricEthNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricEthNetworkPolicyByOrg = Get-IntersightFabricEthNetworkPolicy -Organization $org

#Get the FabricEthNetworkPolicy based on query Parameter
$FabricEthNetworkPolicyByQueryParam = Get-IntersightFabricEthNetworkPolicy -Filter Name eq FabricEthNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .