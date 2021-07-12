#Get the FabricUplinkPcRole by Name
$FabricUplinkPcRoleByName = Get-IntersightFabricUplinkPcRole -Name FabricUplinkPcRoleName

#Get the List of ServerProfiles
$FabricUplinkPcRoleList = Get-IntersightFabricUplinkPcRole

#Get the list of FabricUplinkPcRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricUplinkPcRoleByOrg = Get-IntersightFabricUplinkPcRole -Organization $org

#Get the FabricUplinkPcRole based on query Parameter
$FabricUplinkPcRoleByQueryParam = Get-IntersightFabricUplinkPcRole -Filter Name eq FabricUplinkPcRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .