#Get the IamPermission by Name
$IamPermissionByName = Get-IntersightIamPermission -Name IamPermissionName

#Get the List of ServerProfiles
$IamPermissionList = Get-IntersightIamPermission

#Get the list of IamPermission under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$IamPermissionByOrg = Get-IntersightIamPermission -Organization $org

#Get the IamPermission based on query Parameter
$IamPermissionByQueryParam = Get-IntersightIamPermission -Filter Name eq IamPermissionName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .