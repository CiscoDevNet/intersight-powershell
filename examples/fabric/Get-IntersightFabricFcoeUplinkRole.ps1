#Get the FabricFcoeUplinkRole by Name
$FabricFcoeUplinkRoleByName = Get-IntersightFabricFcoeUplinkRole -Name FabricFcoeUplinkRoleName

#Get the List of ServerProfiles
$FabricFcoeUplinkRoleList = Get-IntersightFabricFcoeUplinkRole

#Get the list of FabricFcoeUplinkRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricFcoeUplinkRoleByOrg = Get-IntersightFabricFcoeUplinkRole -Organization $org

#Get the FabricFcoeUplinkRole based on query Parameter
$FabricFcoeUplinkRoleByQueryParam = Get-IntersightFabricFcoeUplinkRole -Filter Name eq FabricFcoeUplinkRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .