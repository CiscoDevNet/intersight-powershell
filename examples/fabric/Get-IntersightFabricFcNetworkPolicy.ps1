#Get the FabricFcNetworkPolicy by Name
$FabricFcNetworkPolicyByName = Get-IntersightFabricFcNetworkPolicy -Name FabricFcNetworkPolicyName

#Get the List of ServerProfiles
$FabricFcNetworkPolicyList = Get-IntersightFabricFcNetworkPolicy

#Get the list of FabricFcNetworkPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricFcNetworkPolicyByOrg = Get-IntersightFabricFcNetworkPolicy -Organization $org

#Get the FabricFcNetworkPolicy based on query Parameter
$FabricFcNetworkPolicyByQueryParam = Get-IntersightFabricFcNetworkPolicy -Filter Name eq FabricFcNetworkPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .