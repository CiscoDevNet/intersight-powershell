#Get the FabricMulticastPolicy by Name
$FabricMulticastPolicyByName = Get-IntersightFabricMulticastPolicy -Name FabricMulticastPolicyName

#Get the List of ServerProfiles
$FabricMulticastPolicyList = Get-IntersightFabricMulticastPolicy

#Get the list of FabricMulticastPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricMulticastPolicyByOrg = Get-IntersightFabricMulticastPolicy -Organization $org

#Get the FabricMulticastPolicy based on query Parameter
$FabricMulticastPolicyByQueryParam = Get-IntersightFabricMulticastPolicy -Filter Name eq FabricMulticastPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .