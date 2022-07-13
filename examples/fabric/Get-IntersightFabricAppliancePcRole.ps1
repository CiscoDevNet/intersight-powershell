#Get the FabricAppliancePcRole by Name
$FabricAppliancePcRoleByName = Get-IntersightFabricAppliancePcRole -Name FabricAppliancePcRoleName

#Get the List of ServerProfiles
$FabricAppliancePcRoleList = Get-IntersightFabricAppliancePcRole

#Get the list of FabricAppliancePcRole under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$FabricAppliancePcRoleByOrg = Get-IntersightFabricAppliancePcRole -Organization $org

#Get the FabricAppliancePcRole based on query Parameter
$FabricAppliancePcRoleByQueryParam = Get-IntersightFabricAppliancePcRole -Filter Name eq FabricAppliancePcRoleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .