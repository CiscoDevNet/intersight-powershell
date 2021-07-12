#Get the FabricFcUplinkPcRole by Name
$FabricFcUplinkPcRoleByName = Get-IntersightFabricFcUplinkPcRole -Name FabricFcUplinkPcRoleName

#Get the List of ServerProfiles
$FabricFcUplinkPcRoleList = Get-IntersightFabricFcUplinkPcRole

#Get the list of FabricFcUplinkPcRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricFcUplinkPcRoleByOrg = Get-IntersightFabricFcUplinkPcRole -Organization $org

#Get the FabricFcUplinkPcRole based on query Parameter
$FabricFcUplinkPcRoleByQueryParam = Get-IntersightFabricFcUplinkPcRole -Filter Name eq FabricFcUplinkPcRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .