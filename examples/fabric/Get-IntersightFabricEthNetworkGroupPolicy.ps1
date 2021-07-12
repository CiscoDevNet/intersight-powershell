#Get the FabricEthNetworkGroupPolicy by Name
$FabricEthNetworkGroupPolicyByName = Get-IntersightFabricEthNetworkGroupPolicy -Name FabricEthNetworkGroupPolicyName

#Get the List of ServerProfiles
$FabricEthNetworkGroupPolicyList = Get-IntersightFabricEthNetworkGroupPolicy

#Get the list of FabricEthNetworkGroupPolicy under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricEthNetworkGroupPolicyByOrg = Get-IntersightFabricEthNetworkGroupPolicy -Organization $org

#Get the FabricEthNetworkGroupPolicy based on query Parameter
$FabricEthNetworkGroupPolicyByQueryParam = Get-IntersightFabricEthNetworkGroupPolicy -Filter Name eq FabricEthNetworkGroupPolicyName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .