#Get the ManagementEntity by Name
$ManagementEntityByName = Get-IntersightManagementEntity -Name ManagementEntityName

#Get the List of ServerProfiles
$ManagementEntityList = Get-IntersightManagementEntity

#Get the list of ManagementEntity under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ManagementEntityByOrg = Get-IntersightManagementEntity -Organization $org

#Get the ManagementEntity based on query Parameter
$ManagementEntityByQueryParam = Get-IntersightManagementEntity -Filter Name eq ManagementEntityName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .