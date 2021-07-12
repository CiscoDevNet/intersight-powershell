#Get the FabricUplinkRole by Name
$FabricUplinkRoleByName = Get-IntersightFabricUplinkRole -Name FabricUplinkRoleName

#Get the List of ServerProfiles
$FabricUplinkRoleList = Get-IntersightFabricUplinkRole

#Get the list of FabricUplinkRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricUplinkRoleByOrg = Get-IntersightFabricUplinkRole -Organization $org

#Get the FabricUplinkRole based on query Parameter
$FabricUplinkRoleByQueryParam = Get-IntersightFabricUplinkRole -Filter Name eq FabricUplinkRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .