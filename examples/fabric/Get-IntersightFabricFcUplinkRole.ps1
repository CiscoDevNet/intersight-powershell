#Get the FabricFcUplinkRole by Name
$FabricFcUplinkRoleByName = Get-IntersightFabricFcUplinkRole -Name FabricFcUplinkRoleName

#Get the List of ServerProfiles
$FabricFcUplinkRoleList = Get-IntersightFabricFcUplinkRole

#Get the list of FabricFcUplinkRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricFcUplinkRoleByOrg = Get-IntersightFabricFcUplinkRole -Organization $org

#Get the FabricFcUplinkRole based on query Parameter
$FabricFcUplinkRoleByQueryParam = Get-IntersightFabricFcUplinkRole -Filter Name eq FabricFcUplinkRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .