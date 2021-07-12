#Get the FabricApplianceRole by Name
$FabricApplianceRoleByName = Get-IntersightFabricApplianceRole -Name FabricApplianceRoleName

#Get the List of ServerProfiles
$FabricApplianceRoleList = Get-IntersightFabricApplianceRole

#Get the list of FabricApplianceRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$FabricApplianceRoleByOrg = Get-IntersightFabricApplianceRole -Organization $org

#Get the FabricApplianceRole based on query Parameter
$FabricApplianceRoleByQueryParam = Get-IntersightFabricApplianceRole -Filter Name eq FabricApplianceRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .