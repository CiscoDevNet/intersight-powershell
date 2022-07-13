#Get the ManagementInterface by Name
$ManagementInterfaceByName = Get-IntersightManagementInterface -Name ManagementInterfaceName

#Get the List of ServerProfiles
$ManagementInterfaceList = Get-IntersightManagementInterface

#Get the list of ManagementInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$ManagementInterfaceByOrg = Get-IntersightManagementInterface -Organization $org

#Get the ManagementInterface based on query Parameter
$ManagementInterfaceByQueryParam = Get-IntersightManagementInterface -Filter Name eq ManagementInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .