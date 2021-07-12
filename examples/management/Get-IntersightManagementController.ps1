#Get the ManagementController by Name
$ManagementControllerByName = Get-IntersightManagementController -Name ManagementControllerName

#Get the List of ServerProfiles
$ManagementControllerList = Get-IntersightManagementController

#Get the list of ManagementController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$ManagementControllerByOrg = Get-IntersightManagementController -Organization $org

#Get the ManagementController based on query Parameter
$ManagementControllerByQueryParam = Get-IntersightManagementController -Filter Name eq ManagementControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .