#Get the FabricFcoeUplinkPcRole by Name
$FabricFcoeUplinkPcRoleByName = Get-IntersightFabricFcoeUplinkPcRole -Name FabricFcoeUplinkPcRoleName

#Get the List of ServerProfiles
$FabricFcoeUplinkPcRoleList = Get-IntersightFabricFcoeUplinkPcRole

#Get the list of FabricFcoeUplinkPcRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricFcoeUplinkPcRoleByOrg = Get-IntersightFabricFcoeUplinkPcRole -Organization $org

#Get the FabricFcoeUplinkPcRole based on query Parameter
$FabricFcoeUplinkPcRoleByQueryParam = Get-IntersightFabricFcoeUplinkPcRole -Filter Name eq FabricFcoeUplinkPcRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .