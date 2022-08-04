#Get the FabricServerRole by Name
$FabricServerRoleByName = Get-IntersightFabricServerRole -Name FabricServerRoleName

#Get the List of ServerProfiles
$FabricServerRoleList = Get-IntersightFabricServerRole

#Get the list of FabricServerRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricServerRoleByOrg = Get-IntersightFabricServerRole -Organization $org

#Get the FabricServerRole based on query Parameter
$FabricServerRoleByQueryParam = Get-IntersightFabricServerRole -Filter Name eq FabricServerRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .