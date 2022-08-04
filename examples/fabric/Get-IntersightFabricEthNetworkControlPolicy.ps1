#Get the FabricEthNetworkControlPolicy by Name
$FabricEthNetworkControlPolicyByName = Get-IntersightFabricEthNetworkControlPolicy -Name FabricEthNetworkControlPolicyName

#Get the List of ServerProfiles
$FabricEthNetworkControlPolicyList = Get-IntersightFabricEthNetworkControlPolicy

#Get the list of FabricEthNetworkControlPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricEthNetworkControlPolicyByOrg = Get-IntersightFabricEthNetworkControlPolicy -Organization $org

#Get the FabricEthNetworkControlPolicy based on query Parameter
$FabricEthNetworkControlPolicyByQueryParam = Get-IntersightFabricEthNetworkControlPolicy -Filter Name eq FabricEthNetworkControlPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .